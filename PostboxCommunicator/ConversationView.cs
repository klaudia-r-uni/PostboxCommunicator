using PostboxCommunicator.Controllers;
using PostboxCommunicator.Models;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator {
    public partial class ConversationView : Form {
        private ArrayList messages;

        //not sure if "interlocutor" is the right word for it? 
        public ConversationView(string interlocutorName) {
            this.messages = new ArrayList();
             
            InitializeComponent();
            this.Text = interlocutorName; 

            background.BackColor = Color.FromArgb(255, 212, 213, 214);
            footerPanel.BackColor = Color.FromArgb(255, 212, 213, 214);

            MessageModel message = new MessageModel();
            MessageController controller = new MessageController(); 
            message.content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget. Quisque imperdiet, nisl sit amet dapibus lacinia, magna dui convallis ipsum, non dictum velit ligula et augue. Maecenas a ipsum risus. Praesent in dolor sapien. Etiam malesuada diam vitae magna posuere dapibus ac non arcu. Aliquam vehicula turpis mi, ac varius purus porttitor non. Nulla facilisi. Vestibulum laoreet sit amet metus non interdum. Nam libero elit, luctus nec ipsum non, molestie porta justo. Suspendisse ut tincidunt nunc. Vestibulum ultrices faucibus elit a dapibus. Sed fermentum, massa ut lacinia interdum, mauris sapien congue mi, vel imperdiet massa orci sagittis nulla. Aliquam eu facilisis dui, vel dapibus erat.";
            message.authorType = "user";

            TextBox authorsMessage = controller.getMessageBox(message, background);
            background.Controls.Add(authorsMessage);

            MessageModel responseModel = new MessageModel();
            responseModel.content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget.";
            responseModel.authorType = "respondAuthor";

            TextBox response = controller.getMessageBox(responseModel, background);
            background.Controls.Add(response);
            messageContentField.Focus();
        }

        private void background_Resize(object sender, System.EventArgs e) {
            
        }

        private void sendButton_Click(object sender, System.EventArgs e)
        {
            string input = messageContentField.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                sendMessage(input);
            }

        }
        public void sendMessage(string message)
        { 
            MessageController controller = new MessageController();
            MessageModel sendMessage = new MessageModel
            {
                content = message,
                authorType = "user"
            };

            TextBox authorsMessage = controller.getMessageBox(sendMessage, background);
            background.Controls.Add(authorsMessage);
            messageContentField.Focus();
            messageContentField.Clear();

        }

        private void messageContentField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = messageContentField.Text;
                if (!string.IsNullOrWhiteSpace(input))
                {
                    sendMessage(input);
                }
            }
        }
    }
}
