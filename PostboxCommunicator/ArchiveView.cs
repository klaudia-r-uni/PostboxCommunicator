using PostboxCommunicator.Controllers;
using PostboxCommunicator.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator {
    public partial class ArchiveView : Form {
        public ArchiveView() {
            InitializeComponent();
            fillContactList();
            printTwoMessages();
            addStyleToLabels(); 
        }

        private void addStyleToLabels() {
            conversationBetweenLabel.ForeColor = Color.FromArgb(255, 38, 78, 242); 
            dateOneLabel.ForeColor = Color.FromArgb(255, 38, 78, 242); 
            dateTwoLabel.ForeColor = Color.FromArgb(255, 38, 78, 242);
            dateAndLabel.ForeColor = Color.FromArgb(255, 38, 78, 242);
        }

        private void printTwoMessages() {

            MessageModel messageOne = new MessageModel(); 
            messageOne.content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget.";
            messageOne.authorType = "user";

            MessageModel messageTwo = new MessageModel();
            messageTwo.content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget.";
            messageTwo.authorType = "response";

            MessageController controller = new MessageController();
            TextBox message = controller.getMessageBox(messageOne, messageContentPanel); 
            TextBox response = controller.getMessageBox(messageTwo, messageContentPanel);

            messageContentPanel.Controls.Add(message);
            messageContentPanel.Controls.Add(response);
        }

        public void fillContactList() {
            //TODO change to be real contact list
            String[] users = { "Harry Potter", "Hermiona Granger", "Ronald Wesley", "Draco Malfoy", "Ginny Wesley", "Albus Dumbledore", "Severus Snape" };
            int i = 0;
            foreach (String user in users) {
                this.getNewContact(user, i);
                i++;
            }
        }

        private void getNewContact(string user, int i) {
            Label contact = new Label();
            int fontSize = 12;
            contact.Padding = new Padding(10, 4, 4, 4);
            contact.TextAlign = ContentAlignment.MiddleLeft;
            contact.Font = new Font("Arial", fontSize);
            contact.Height = fontSize * 3;
            contact.Margin = new Padding(0, 2, 0, 2);
            if (i % 2 == 0) {
                contact.BackColor = Color.FromArgb(255, 122, 138, 204);
            } else {
                contact.BackColor = Color.FromArgb(255, 147, 160, 214);
            }
            contact.Text = user;
            contact.Width = contactListArchivePanel.Width - 15;
            contactListArchivePanel.Controls.Add(contact);
        }
    }
}
