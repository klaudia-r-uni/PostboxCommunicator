using PostboxCommunicator.Controllers;
using PostboxCommunicator.Models;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace PostboxCommunicator {
    partial class ConversationView : Form {
        private ArrayList messages;
        private UserModel interlocutorModel;
        private const int NUMBER_OF_MESSAGES_TO_LOAD_ON_SCROLL = 1;

        public ConversationView(UserModel interlocutorModel) {
            this.interlocutorModel = interlocutorModel;
            this.messages = new ArrayList();

            InitializeComponent();
            this.background.MouseWheel += background_MouseWheel;

            this.Text = interlocutorModel.displayName;

            background.BackColor = Color.FromArgb(255, 212, 213, 214);
            footerPanel.BackColor = Color.FromArgb(255, 212, 213, 214);

            this.displayMessages();
            messageContentField.Focus();
        }

        private void handleScroll(object sender, ScrollEventArgs scroll = null, MouseEventArgs wheel = null) {
            //@TODO optimize 
            if (scroll != null) {
                if (scroll.NewValue < 5) {
                    this.loadMoreMessages();
                }
            }
            if (wheel != null) {
                if (background.VerticalScroll.Value < 5) {
                    this.loadMoreMessages();
                }
            }
        }

        private int cnt = 0;
        private void loadMoreMessages() {
            ArrayList newMessages = this.getArrayListOfMessages();
        

            this.messagesGrid.Visible = false;
            //shift everything
            int rowCount = this.messagesGrid.RowCount-1;
            this.messagesGrid.RowCount += NUMBER_OF_MESSAGES_TO_LOAD_ON_SCROLL;
            for (int i=rowCount-1; i>=0; --i) {
                Control row = this.messagesGrid.GetControlFromPosition(0, i);
                this.messagesGrid.SetRow(row, i + NUMBER_OF_MESSAGES_TO_LOAD_ON_SCROLL);
            }
            //insert new rows at the beginning 
            for (int i = NUMBER_OF_MESSAGES_TO_LOAD_ON_SCROLL; i > 0; i--) { //>=0
                ((MessageModel)newMessages[i]).content = (++cnt).ToString();
                FlowLayoutPanel messageContainer = this.attachMessage((MessageModel)newMessages[i]);
                this.messagesGrid.Controls.Add(messageContainer, 0, 0);
            }

            this.messagesGrid.Visible = true;
        }






        private void displayMessages() {
            ArrayList messages = this.getArrayListOfMessages();
            foreach (MessageModel message in messages) {
                FlowLayoutPanel messageContainer = this.attachMessage(message);
                this.messagesGrid.Controls.Add(messageContainer, 0, this.messagesGrid.RowCount-1);
                this.messagesGrid.RowCount++;

            }
        }

        private ArrayList getArrayListOfMessages() {
            int numberOfMessagesToShow = 15;

            ArrayList messages = new ArrayList();

            for (int i = 0; i < numberOfMessagesToShow; i++) {
                MessageModel message = new MessageModel();

                if (i % 2 == 0) {
                    message.content = i.ToString() + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget. Quisque imperdiet, nisl sit amet dapibus lacinia, magna dui convallis ipsum, non dictum velit ligula et augue. Maecenas a ipsum risus. Praesent in dolor sapien. Etiam malesuada diam vitae magna posuere dapibus ac non arcu. Aliquam vehicula turpis mi, ac varius purus porttitor non. Nulla facilisi. Vestibulum laoreet sit amet metus non interdum. Nam libero elit, luctus nec ipsum non, molestie porta justo. Suspendisse ut tincidunt nunc. Vestibulum ultrices faucibus elit a dapibus. Sed fermentum, massa ut lacinia interdum, mauris sapien congue mi, vel imperdiet massa orci sagittis nulla. Aliquam eu facilisis dui, vel dapibus erat.";
                    message.recipientId = ApplicationState.user.username;
                    message.senderId = this.interlocutorModel.username;
                } else {
                    message.content = i.ToString() + "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget. Quisque imperdiet, nisl sit amet dapibus lacinia, magna dui convallis ipsum, non dictum velit ligula et augue. Maecenas a ipsum risus. Praesent in dolor sapien. Etiam malesuada diam vitae magna posuere dapibus ac non arcu. Aliquam vehicula turpis mi, ac varius purus porttitor non. Nulla facilisi. Vestibulum laoreet sit amet metus non interdum. Nam libero elit,";
                    message.recipientId = interlocutorModel.username;
                    message.senderId = ApplicationState.user.username;
                }
                messages.Add(message);
            }
            return messages;
        }

        private FlowLayoutPanel attachMessage(MessageModel message) {
            Label messageTime = new Label();
            messageTime.Text = message.dateTime.ToString();
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

            //background.Controls.Add(messageContainer);
            return messageContainer;
        }

        private void ConversationView_Scroll(object sender, ScrollEventArgs e) {
            this.handleScroll(sender, e, null);
        }

        private void background_MouseWheel(object sender, MouseEventArgs e) {
            this.handleScroll(sender, null, e);
        }
    }
}
