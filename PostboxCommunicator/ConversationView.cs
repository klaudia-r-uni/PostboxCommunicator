using PostboxCommunicator.Controllers;
using PostboxCommunicator.Models;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PostboxCommunicator.Infrastructure;

namespace PostboxCommunicator {
    public partial class ConversationView : Form {
        private UserModel interlocutorModel;
        ClientServerCommunication server;
        private List<MessageModel> newMessageBuffer;
        private Boolean loadingMessages;
        //get greatest id for convo.
        private int messageLower = 1200;



        public ConversationView(UserModel interlocutorModel) {
            server = ClientServerCommunication.Instance;
            this.interlocutorModel = interlocutorModel;
            loadingMessages = false;

            InitializeComponent();
            background.MouseWheel += background_MouseWheel;

            newMessageBuffer = new List<MessageModel>();

            Text = interlocutorModel.displayName;

            background.BackColor = Color.FromArgb(255, 212, 213, 214);
            footerPanel.BackColor = Color.FromArgb(255, 212, 213, 214);
            displayMessages();
            messageContentField.Focus();

        }

        private void handleScroll(object sender, ScrollEventArgs scroll = null, MouseEventArgs wheel = null) {
            //@TODO optimize 
            if (scroll != null) {

                if (scroll.NewValue < 5) {
                    loadMoreMessages();
                }
            }
            else if (wheel != null) {
                if (background.VerticalScroll.Value < 5) {
                    loadMoreMessages();
                }
            }
        }

        private async void loadMoreMessages() {
            if (loadingMessages) {
                return;
            }

            loadingMessages = true;

            if (newMessageBuffer.Count == 0) {
                newMessageBuffer.Clear();
                newMessageBuffer = await getArrayListOfMessages();
            }

            if (newMessageBuffer.Any()){
                //sets message
                MessageModel message = newMessageBuffer[0];
                newMessageBuffer.RemoveAt(0);

                //attaches message to panel and sets rowStyle
                FlowLayoutPanel messageContainer = attachMessage(message);
                messagesGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, messageContainer.Height));

                //adds row
                messagesGrid.RowCount++;

                //moves all the rows down one
                foreach (Control c in messagesGrid.Controls) {
                    this.messagesGrid.SetRow(c, messagesGrid.GetRow(c) + 1);
                }

                //adds message to messageGrid
                messagesGrid.Controls.Add(messageContainer, 0, 0);

                loadingMessages = false;

            }
            
        }

        private async void displayMessages() {
            messagesGrid.Visible = false;
            FlowLayoutPanel messageContainer = null;

            List<MessageModel> messagesToDisplay = await getArrayListOfMessages();

            if (messagesToDisplay.Any()){
                messagesToDisplay.Reverse();

                foreach (MessageModel message in messagesToDisplay) {
                    messageContainer = this.attachMessage(message);
                    messagesGrid.Controls.Add(messageContainer);
                }
            }           

            messagesGrid.Visible = true;
            background.ScrollControlIntoView(messageContainer);
        }

        private async Task<List<MessageModel>> getArrayListOfMessages() {
            List<MessageModel> messagesFromServer = await server.getMessages(messageLower, server.client.username, interlocutorModel.username);
            if (messagesFromServer.Any()){
                messageLower = messagesFromServer.Select(x => x.id).Min();
            }

            return messagesFromServer;
        }

        private FlowLayoutPanel attachMessage(MessageModel message) {
            Label messageTime = new Label();
            messageTime.Text = message.dateTime;
            messageTime.TextAlign = ContentAlignment.MiddleRight;
            messageTime.Padding = new Padding(0, 0, 10, 0);

            MessageController controller = new MessageController();

            TextBox authorsMessage = controller.getMessageBox(message, background);

            FlowLayoutPanel messageContainer = new FlowLayoutPanel();
            messageContainer.BackColor = authorsMessage.BackColor;

            messageContainer.Width = authorsMessage.Width + 100;
            messageContainer.Height = authorsMessage.Height + 50;

            messageTime.Width = messageContainer.Width;

            messageContainer.Controls.Add(messageTime);
            messageContainer.Controls.Add(authorsMessage);

            return messageContainer;
        }

        private void ConversationView_Scroll(object sender, ScrollEventArgs e) {

            handleScroll(sender, e, null);
        }

        private void background_MouseWheel(object sender, MouseEventArgs e) {
            handleScroll(sender, null, e);
        }

        private void sendButton_Click(object sender, EventArgs e) {
            string input = messageContentField.Text;
            if (!string.IsNullOrWhiteSpace(input)) {
                sendMessage(input);
            }
        }

        //https://stackoverflow.com/questions/661561/how-do-i-update-the-gui-from-another-thread
        //above for how to implement cross thread ui updating
        public void recMessage(MessageModel message){
            Invoke((MethodInvoker)(() =>
                {
                    FlowLayoutPanel messageContainer = attachMessage(message);
                    messagesGrid.Controls.Add(messageContainer);
                    background.ScrollControlIntoView(messageContainer);
                    messageContentField.Focus();
                    messageContentField.Clear();
                    messagesGrid.RowCount++;
                }
            ));   
        }

        public void sendMessage(string message) {

            MessageModel sendMessage = new MessageModel();
            sendMessage.content = message;
            sendMessage.recipientId = interlocutorModel.username;
            sendMessage.senderId = server.client.username;
            sendMessage.dateTime = DateTime.Now.ToString();

            server.sendMessage(sendMessage);
            FlowLayoutPanel messageContainer = attachMessage(sendMessage);
            messagesGrid.Controls.Add(messageContainer);
            background.ScrollControlIntoView(messageContainer);
            messageContentField.Focus();
            messageContentField.Clear();
            messagesGrid.RowCount++;
        }

        private void messageContentField_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                string input = messageContentField.Text;
                if (!string.IsNullOrWhiteSpace(input)) {
                    sendMessage(input);
                }
            }
        }



    }
}