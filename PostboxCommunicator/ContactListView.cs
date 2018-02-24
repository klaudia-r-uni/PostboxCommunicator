using PostboxCommunicator.Mocks;
using PostboxCommunicator.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator {
    public partial class ContactListView : Form {

        public ContactListView() {

            if (ApplicationState.user == null) {
                LogInView logInView = new LogInView();
                logInView.Show();
            } else {
                InitializeComponent();
                menuPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
                contactListPanel.BackColor = Color.FromArgb(255, 212, 213, 214);
                footerPanel.BackColor = Color.FromArgb(255, 159, 170, 218);

                //ConversationView conversation = new ConversationView();
                //ArchiveView archive = new ArchiveView();
                //FeedbackView feedback = new FeedbackView(); 
                fillContactList();

                //archive.Show();
                //conversation.Show();
                //feedback.Show();
            }
        }

        public void fillContactList() {
            ArrayList users = ApiMock.getListOfContacts();
            int i = 0; 
            foreach( UserModel user in users) {
                this.addNewContactToList(user, i);
                i++;
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
                if (ApiMock.isContactOnline(user.id)) {
                    contact.BackColor = Color.FromArgb(255, 90, 119, 237);
                } else {
                    contact.BackColor = Color.FromArgb(255, 122, 138, 204);
                }
            } else {
                if (ApiMock.isContactOnline(user.id)) {
                    contact.BackColor = Color.FromArgb(255, 89, 109, 192);
                } else {
                    contact.BackColor = Color.FromArgb(255, 147, 160, 214);
                }
            }

            if( ApiMock.isContactOnline(user.id)) {
                contact.Text = ":-) " + user.displayName;
            } else {
                contact.Text = ":-( " + user.displayName;
            }
            contact.Tag = user;
            contact.Click += new EventHandler(label_Click); 
            contact.Width = contactFlowPanel.Width - 15;
            contactFlowPanel.Controls.Add(contact);
        }

        private void label_Click(object sender, EventArgs e) {
            Label label = (Label)sender;
            ConversationView conversation = new ConversationView((UserModel)label.Tag);
            conversation.Show();
        }

        private void ContactListView_FormClosed(object sender, FormClosedEventArgs e) {
            LogInView loginView = new LogInView();
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
    }
}
