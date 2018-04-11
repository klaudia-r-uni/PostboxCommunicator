using PostboxCommunicator.Models;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator {
    public partial class NotificationView : Form {
        
        public NotificationView(UserModel contact) {
            InitializeComponent();
            contactLabel.Text = contact.displayName + " has just sent you a message!";
            this.BackColor = Color.FromArgb(255, 159, 170, 218);
        }
        
    }
}
