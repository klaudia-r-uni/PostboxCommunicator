using System;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
            menuPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
            contactListPanel.BackColor = Color.FromArgb(255, 212, 213, 214);
            footerPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
            string interlocutor = "Harry Potter";

            ConversationView conversation = new ConversationView(interlocutor);
            LogInView logIn = new LogInView();
            ArchiveView archive = new ArchiveView();
            FeedbackView feedback = new FeedbackView(); 
            fillContactList();

            //archive.Show();
            //logIn.Show();
            conversation.ShowDialog();
            //feedback.Show();
        }

        public void fillContactList() {
            //TODO change to be real contact list
            String[] users = { "Harry Potter", "Hermiona Granger", "Ronald Wesley", "Draco Malfoy", "Ginny Wesley", "Albus Dumbledore", "Severus Snape" };
            int i = 0; 
            foreach( String user in users) {
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
            if( i % 2 == 0) {
                contact.BackColor = Color.FromArgb(255, 122, 138, 204);
            } else {
                contact.BackColor = Color.FromArgb(255, 147, 160, 214);
            }
            contact.Text = user;
            contact.Width = contactFlowPanel.Width - 15;
            contactFlowPanel.Controls.Add(contact);
        }
    }
}
