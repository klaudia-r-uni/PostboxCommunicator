using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostboxCommunicator
{
    public partial class LogInView : Form
    {
        public LogInView()
        {
            InitializeComponent();
            this.centerThePanel();

            logInBackgroundPanel.Anchor = AnchorStyles.None;
            this.BackColor = Color.FromArgb(255, 212, 213, 214);
            logInBackgroundPanel.BackColor = Color.FromArgb(255, 159, 170, 218);
            loginLabel.ForeColor = Color.FromArgb(255, 38, 78, 242);
            passwordLabel.ForeColor = Color.FromArgb(255, 38, 78, 242);

        }

        private void centerThePanel()
        {
            logInBackgroundPanel.Location = new Point(
               this.ClientSize.Width / 2 - logInBackgroundPanel.Size.Width / 2,
               this.ClientSize.Height / 2 - logInBackgroundPanel.Size.Height / 2
            );
        }





        private void LogInView_Load(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {

            try
            {

                string em = textLogin.Text;
                string pass = textBox2.Text;

                lblLoginError.Text = "";
                lblerror2.Text = "";

                hackcheck();




                if (textLogin.TextLength == 0)
                {
                    lblLoginError.Text = "Field cannot be empty ";
                }
                else if (em.IndexOf("@") > -1)
                {

                    if (em.IndexOf(".", em.IndexOf("@")) > em.IndexOf("@"))
                    {

                        lblerror2.Text = "this is not in email format";
                    }
                }


                else if (textBox2.TextLength == 0)
                {
                    lblLoginError.Text = "Field cannot be empty ";

                }



                else
                {

                    login();


                }
            }
            catch
            {
                lblerror2.Text = "Sorry an unknown error has occured";

            }
        }



        public void login()
        {

            try
            {
                //db connection code here

                // to be changed to check against the db username and password
                string dbusername = "a";
                string dbPassword = "a";

                if (textLogin.Text != dbusername)
                {
                    lblLoginError.Text = "User name or Password is incorrect";
                }
                else if (textBox2.Text != dbPassword)
                {
                    lblLoginError.Text = "User name or Password is incorrect";
                }
                else
                {
                    lblLoginError.Text = "welcome";

                }


            }
            catch
            {
                FeedbackView.Show("Sorry error connecting to the server", "Connection Error");
               
            }

        }


        public void hackcheck()
        {
            
            List<string> banned = new List<string>();
            banned.Add("\"");
            banned.Add("\b");
            banned.Add("\n");
            banned.Add("\r");
            banned.Add("\t");
            banned.Add("\\");
            banned.Add("INSERT");
            banned.Add("AND");
            banned.Add("FROM");
            banned.Add("WHERE");

            foreach (var b in banned)
            {
                if (textLogin.Text.Contains(b) || textBox2.Text.Contains(b))
                {
                    lblerror2.Text = "Please stop trying to hack us :)";

                }
            }

        }



        private void textLogin_TextChanged(object sender, EventArgs e)
        {
            lblerror2.Text = "";

            hackcheck();
        }

      

        private void textBox2_TextChanged(object sender, EventArgs e )
        {
            lblerror2.Text = "";
            hackcheck();
        }
    }

}

