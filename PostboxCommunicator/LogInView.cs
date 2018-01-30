using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


      


        private void LogInView_Load(object sender, EventArgs e)
        {

        }
    }
}
