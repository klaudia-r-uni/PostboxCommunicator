using PostboxCommunicator.Mocks;
using PostboxCommunicator.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator {
    public partial class LogInView : Form {
        public LogInView() {
            InitializeComponent();
            this.centerThePanel();
   
            logInBackgroundPanel.Anchor = AnchorStyles.None;
            this.BackColor = Color.FromArgb(255, 212, 213, 214);
            logInBackgroundPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
            loginLabel.ForeColor = Color.FromArgb(255, 38, 78, 242); 
            passwordLabel.ForeColor = Color.FromArgb(255, 38, 78, 242);
        }

        private void centerThePanel() {
            logInBackgroundPanel.Location = new Point(
               this.ClientSize.Width / 2 - logInBackgroundPanel.Size.Width / 2,
               this.ClientSize.Height / 2 - logInBackgroundPanel.Size.Height / 2
            );
        }

        private void sendButton_Click(object sender, EventArgs e) {
            string login = loginInput.Text;
            string password = passwordInput.Text;
            try {
                if (this.credentialsValid(login, password)) {
                    ApiMock api = new ApiMock();
                    UserModel user = api.logUserIn(login, password);
                    if (user != null) {
                        ApplicationState.user = user;
                        ContactListView menu = new ContactListView();
                        menu.Show();
                        this.Hide();
                    }
                } else {
                    throw new Exception("Your credentials are invalid");
                }
            }
            catch (Exception exception ) {
                FeedbackView feedback = new FeedbackView();
                feedback.setCustomizedMessage(exception.Message); 
                feedback.ShowDialog(); 
            }
        }

        private bool credentialsValid(string login, string password) {
            return false; 
        }
    }
}
