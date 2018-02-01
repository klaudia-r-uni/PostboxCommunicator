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




                //else
                //{
                //    string sql = "SELECT User FROM Users WHERE UserName = @Username AND Password = @Password";

                //    //login 
                //    using (SqlConnection connection = new SqlConnection(/* connection info */))
                //    using (SqlCommand command = new SqlCommand(sql, connection))
                //    {

                //        SqlParameter userName = new SqlParameter("@Username", SqlDbType.Text);
                //        SqlParameter password = new SqlParameter("@Password", SqlDbType.Text);

                //        userName.Value = em;
                //        password.Value = pass;


                //        command.Parameters.Add(userName);
                //        command.Parameters.Add(password);
                //        var results = command.ExecuteReader();

                //    }

                //    if(sql == null)
                //    {
                //        lblLoginError.Text = "Wrong Details entered, Try again";
                //    }
                //}

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

                if(textLogin.Text !=  dbusername)
                {
                    lblLoginError.Text = "User name or Password is incorrect";
                }
                else if(textBox2.Text != dbPassword)
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
                new LogInView();
            }

        }



        public void hackcheck()
        {

            if (textLogin.Text.Contains("\0") || textBox2.Text.Contains("\0"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("\'") || textBox2.Text.Contains("\'"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("\"") || textBox2.Text.Contains("\""))
            {
                lblerror2.Text = "Please stop trying to hack us :)";


            }
            else if (textLogin.Text.Contains("\b") || textBox2.Text.Contains("\b"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("\n") || textBox2.Text.Contains("\n"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("\r") || textBox2.Text.Contains("\r"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("\t") || textBox2.Text.Contains("\t"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("\\") || textBox2.Text.Contains("\\"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            //else if(textLogin.Text.Contains("\Z") || textBox2.Text.Contains("\Z"))
            //{
            //    lblerror2.Text = "Please stop trying to hack us :)";

            //}
            //else if (textLogin.Text.Contains("\%") || textBox2.Text.Contains("\%"))
            //{
            //    lblerror2.Text = "Please stop trying to hack us :)";

            //}
            //else if (textLogin.Text.Contains("\_") || textBox2.Text.Contains("\_"))
            //{
            //    lblerror2.Text = "Please stop trying to hack us :)";

            //}
            else if (textLogin.Text.Contains("INSERT") || textBox2.Text.Contains("INSERT"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("AND") || textBox2.Text.Contains("AND"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";


            }
            else if (textLogin.Text.Contains("WHERE") || textBox2.Text.Contains("WHERE"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }
            else if (textLogin.Text.Contains("FROM") || textBox2.Text.Contains("FROM"))
            {
                lblerror2.Text = "Please stop trying to hack us :)";

            }

        }




    }
}
//    }
//}
