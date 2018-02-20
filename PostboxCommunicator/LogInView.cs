using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
            // move to new void use username and password as the parameters
            string em = textLogin.Text;
            string pass = textBox2.Text;
            onclickauthenticate(em,pass);

           
        }

        public void authenticate()
        {
            //string em = textLogin.Text;
            //string pass = textBox2.Text;
          


                lblLoginError.Text = "";
                lblerror2.Text = "";

                hackcheck();

        }


        public void onclickauthenticate(string em, string pass)
        {
            try { 
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
                string dbPassword = "b";

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

                    //make more efficient at later date 

                    string Username = textLogin.Text;
                    string Pass = textBox2.Text;
                    string pcipherText = PassEncrypt(Pass, Username);
                    string ucipherText = UserEncrypt(Pass, Username);



                    string Passdecryptedstring = PassDecrypt(pcipherText, Username);
                    string Userdecryptedstring = PassDecrypt(ucipherText, Pass);



                    lblLoginError.Text = ucipherText;

                    lblerror2.Text = Userdecryptedstring;



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
            lblLoginError.Text = "";
            lblerror2.Text = "";

            hackcheck();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblLoginError.Text = "";
            lblerror2.Text = "";
            hackcheck();
        }




        private const int Keysize = 256;

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;


        public static string PassEncrypt(string Pass, string Username)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(Pass);
            using (var password = new Rfc2898DeriveBytes(Username, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                
                                return Convert.ToBase64String(cipherTextBytes);
                               

                                
                            }
                        }
                    }
                }

            }
           
            
        }


        public static string UserEncrypt(string Pass, string Username)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(Username);
            using (var password = new Rfc2898DeriveBytes(Pass, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();

                                return Convert.ToBase64String(cipherTextBytes);



                            }
                        }
                    }
                }

            }


        }



        public static string PassDecrypt(string cipherText, string Username)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(Username, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        public static string UserDecrypt(string cipherText, string Pass)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(Pass, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        private void logInBackgroundPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

