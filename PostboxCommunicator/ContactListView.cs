using PostboxCommunicator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PostboxCommunicator.Infrastructure;

namespace PostboxCommunicator {
    public partial class ContactListView : Form{

        private ClientServerCommunication server;
        private Dictionary<String, ConversationView> conversations;

        public ContactListView() {

            if (ApplicationState.user == null) {
                LogInView logIn = new LogInView();
                logIn.Show();
            } else {
                InitializeComponent();
                menuPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
                contactListPanel.BackColor = Color.FromArgb(255, 212, 213, 214);
                footerPanel.BackColor = Color.FromArgb(255, 159, 170, 218);

                server = ClientServerCommunication.Instance;
                server.setContacts(this);

                conversations = new Dictionary<String, ConversationView>();
                fillContactList();
            }
        }

        public async void fillContactList() {
            
            List<UserModel> users = await server.getUsers();
            int i = 0; 
            foreach( UserModel user in users) {
                if (!user.username.Equals(server.client.username)){
                    addNewContactToList(user, i);
                    i++;
                }
            }
        }

        private void addNewContactToList(UserModel user, int i) {
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

            contact.Text = user.displayName;
            contact.Tag = user;
            contact.Click += new EventHandler(label_Click); 
            contact.Width = contactFlowPanel.Width - 15;
            contactFlowPanel.Controls.Add(contact);
        }

        private void label_Click(object sender, EventArgs e) {
            Label label = (Label)sender;
            UserModel user = (UserModel)label.Tag;
            String senderString = user.username;

            if (isOpen(senderString)) {
                ConversationView conversation = getConversation(senderString);
                conversation.WindowState = FormWindowState.Minimized;
                conversation.Show();
                conversation.WindowState = FormWindowState.Normal;
            }
            else {
                ConversationView conversation = new ConversationView(user, this);
                conversations.Add(user.username, conversation);
                conversation.Show();
            }
        }

        private void helpButton_Click(object sender, EventArgs e) {
            HelpView help = new HelpView();
            help.Show();
        }

        public bool isOpen(string sender){
            return conversations.ContainsKey(sender);
        }

        public ConversationView getConversation(string sender) {
            return conversations[sender];
        }

        private void ContactListView_FormClosed(object sender, FormClosedEventArgs e) {
            LogInView loginView = new LogInView();
            server.logout();
            loginView.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e) {
            ApplicationState.user = null;

            this.closeAllFormsExceptMain();
        }


        //https://stackoverflow.com/a/9029389/6139118
        private void closeAllFormsExceptMain() {
            List<Form> openForms = new List<Form>();

            FormCollection formsList = Application.OpenForms;

            for (int i = formsList.Count - 1; i > 0; i--) {
                if (formsList[i].Name != "LogInView") {
                    formsList[i].Close();
                }
            }
        }

        public void updateOnlineUsers(List<string> usersOnline) {
            Invoke((MethodInvoker)(() =>
                {
                    usersOnline.ForEach(markUserOnline);
                }
            ));
        }

        private void markUserOnline(string user){
            foreach (Control control in contactFlowPanel.Controls){
                if (control.GetType() == typeof(Label) && control.Text.Equals(user)) {
                    control.BackColor = Color.FromArgb(255, 255, 250, 139);
                }
            }
        }

        public void conversationClosed(UserModel user){
            conversations.Remove(user.username);
        }
    }
}
