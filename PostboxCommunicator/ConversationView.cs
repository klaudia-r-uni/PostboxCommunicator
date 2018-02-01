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
            message.content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget. Quisque imperdiet, nisl sit amet dapibus lacinia, magna dui convallis ipsum, non dictum velit ligula et augue. Maecenas a ipsum risus. Praesent in dolor sapien. Etiam malesuada diam vitae magna posuere dapibus ac non arcu. Aliquam vehicula turpis mi, ac varius purus porttitor non. Nulla facilisi. Vestibulum laoreet sit amet metus non interdum. Nam libero elit, luctus nec ipsum non, molestie porta justo. Suspendisse ut tincidunt nunc. Vestibulum ultrices faucibus elit a dapibus. Sed fermentum, massa ut lacinia interdum, mauris sapien congue mi, vel imperdiet massa orci sagittis nulla. Aliquam eu facilisis dui, vel dapibus erat.";
            message.recipientId = "HarryPotter";
            message.senderId = "HermionaGranger";

            this.attacheMessage(message);

            MessageModel response = new MessageModel();
            response.content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget.";
            response.senderId = "HarryPotter";
            response.recipientId = "HermionaGranger";

            this.attacheMessage(response);

            messageContentField.Focus();
        }

        private void attacheMessage(MessageModel message) {
            Label messageTime = new Label();
            messageTime.Text = message.dateTime.ToString();
            messageTime.TextAlign = ContentAlignment.MiddleRight;
            messageTime.Padding = new Padding(0,0,10,0);

            MessageController controller = new MessageController();

            TextBox authorsMessage = controller.getMessageBox(message, background);

            FlowLayoutPanel messageContainer = new FlowLayoutPanel();
            messageContainer.BackColor = authorsMessage.BackColor; 

            messageContainer.Width = authorsMessage.Width + 100;
            messageContainer.Height = authorsMessage.Height + 50;

            messageTime.Width = messageContainer.Width;

            messageContainer.Controls.Add(messageTime);
            messageContainer.Controls.Add(authorsMessage);

            background.Controls.Add(messageContainer);
        }

        private void background_Resize(object sender, System.EventArgs e) {

        }
    }
}
