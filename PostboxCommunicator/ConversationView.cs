﻿
using PostboxCommunicator.Models;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostboxCommunicator.Infrastructure;

namespace PostboxCommunicator {
    public partial class ConversationView : Form {
        private UserModel interlocutorModel;
        ClientServerCommunication server;
        private List<MessageModel> newMessageBuffer;
        private bool loadingMessages;
        private int messageLower = int.MaxValue;
        private ContactListView contacts;

        public ConversationView(UserModel interlocutorModel, ContactListView contacts) {
            server = ClientServerCommunication.Instance;
            this.interlocutorModel = interlocutorModel;
            loadingMessages = false;

            this.contacts = contacts;

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
            } else if (wheel != null) {
                if (background.VerticalScroll.Value < 5) {
                    loadMoreMessages();
                }
            }
        }

        private async void loadMoreMessages() {
            //If loading messages don't load anymore.
            if (loadingMessages) return;
            
            loadingMessages = true;

            if (newMessageBuffer.Count == 0) {
                //if random newer message appears in older messages uncomment line below.
                //newMessageBuffer.Clear();
                newMessageBuffer = await getArrayListOfMessages();
            }

            if (newMessageBuffer.Any()) {
                //adds row
                messagesGrid.RowCount++;
                //sets message
                MessageModel message = newMessageBuffer[0];
                newMessageBuffer.RemoveAt(0);
                //moves all the rows down one
                foreach (Control c in messagesGrid.Controls) {
                    messagesGrid.SetRow(c, messagesGrid.GetRow(c) + 1);
                }
                //adds message to messageGrid
                messagesGrid.Controls.Add(getMessageView(message), 0, 0);
                loadingMessages = false;
            }

        }

        private async void displayMessages() {
            messagesGrid.Visible = false;
            List<MessageModel> messagesToDisplay = await getArrayListOfMessages();

            if (messagesToDisplay.Any()) {
                messagesToDisplay.Reverse();

                foreach (MessageModel message in messagesToDisplay) {
                    messageContainer = attachMessage(message);
                    messagesGrid.Controls.Add(messageContainer);
                }
            }

            messagesGrid.Visible = true;
            //background.ScrollControlIntoView(messagesGrid.Controls[0]);
        }

        private async Task<List<MessageModel>> getArrayListOfMessages() {
            List<MessageModel> messagesFromServer = await server.getMessages(messageLower, server.client.username, interlocutorModel.username);
            if (messagesFromServer.Any()) {
                messageLower = messagesFromServer.Select(x => x.id).Min();
            }

            return messagesFromServer;
        }

        private MessageView getMessageView(MessageModel message) {
            MessageView messageView = new MessageView(message);
            if (message.recipientId == ApplicationState.user.username) {
                //blue
                messageView.SetColour(Color.FromArgb(255, 159, 170, 218));
            } else if (message.senderId == ApplicationState.user.username) {
                //yellow
                messageView.SetColour(Color.FromArgb(255, 255, 250, 139));
            }
            messageView.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            return messageView;
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
        public void recMessage(MessageModel message) {
            Invoke((MethodInvoker)(() =>
            {
                MessageView messageView = getMessageView(message);
                messagesGrid.Controls.Add(messageView);
                background.ScrollControlIntoView(messageView);
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
            MessageView messageView = getMessageView(sendMessage);
            messagesGrid.Controls.Add(messageView);
            background.ScrollControlIntoView(messageView);
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

        private void ConversationView_FormClosed(object sender, FormClosedEventArgs e) {
            contacts.conversationClosed(interlocutorModel);

        }


    }
}