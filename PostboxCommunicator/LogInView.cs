using PostboxCommunicator.Mocks;
using PostboxCommunicator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PostboxCommunicator.Infrastructure;

namespace PostboxCommunicator {
    public partial class LogInView : Form {
        ClientServerCommunication server;
        public LogInView() {
            InitializeComponent();
            this.centerThePanel();
   
            logInBackgroundPanel.Anchor = AnchorStyles.None;
            this.BackColor = Color.FromArgb(255, 212, 213, 214);
            logInBackgroundPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
            loginLabel.ForeColor = Color.FromArgb(255, 38, 78, 242); 
            passwordLabel.ForeColor = Color.FromArgb(255, 38, 78, 242);

            server = ClientServerCommunication.Instance;
        }

        private void centerThePanel() {
            logInBackgroundPanel.Location = new Point(
               this.ClientSize.Width / 2 - logInBackgroundPanel.Size.Width / 2,
               this.ClientSize.Height / 2 - logInBackgroundPanel.Size.Height / 2
            );
        }

        private async void sendButton_Click(object sender, EventArgs e) {


            LoginModel loginModel = new LoginModel();
            loginModel.username = loginInput.Text;
            loginModel.password = passwordInput.Text;
            


            try {
                if (this.credentialsValid(loginModel.username, loginModel.password)) {
                    //ApiMock api = new ApiMock();
                    //UserModel user = api.logUserIn(login, password);
                    string error = await server.login(loginModel);
                    Console.Out.WriteLine(error);

                    if (error == "true")
                    {
                        server.joinList();

                        ApplicationState.user = new UserModel();
                        ApplicationState.user.username = loginModel.username;
                        ApplicationState.user.displayName = loginModel.username;
                        ContactListView menu = new ContactListView();
                        menu.Show();
                        this.Hide();
                    }
                    else {
                        FeedbackView feedback = new FeedbackView();
                        feedback.setCustomizedMessage(error);
                        feedback.ShowDialog();
                    }
                } else {
                    throw new Exception("Your credentials are invalid");
                }
            }
            catch (Exception exception) {
                FeedbackView feedback = new FeedbackView();
                feedback.setCustomizedMessage(exception.Message); 
                feedback.ShowDialog(); 
            }
        }

        private bool credentialsValid(string login, string password) {
            return true; 
        }

        private void LogInView_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
