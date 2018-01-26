using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostboxCommunicator
{
    public partial class FeedbackView : Form
    {
        public FeedbackView()
        {
            InitializeComponent();
        }

        // public FeedbackView(string errormessage)
        //{
        //    InitializeComponent();

        //  string em = errormessage;

        // messageContent.Text = em.ToString();
        // }

        static FeedbackView MsgBox; static DialogResult result = DialogResult.No;
        ////////////////////////////////////////////////////////////////////////////////

        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new FeedbackView();
            MsgBox.messageContent.Text = Text;
            MsgBox.button1.Text = btnOK;
            MsgBox.button2.Text = btnCancel;
            MsgBox.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }
        ////////////////////////////////////////////////////////////////////////////////



        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            Application.Exit();

        }

        private void messageContent_TextChanged(object sender, EventArgs e)
        {
            //  messageContent.Text = em;
        }


        private void FeedbackView_Load(object sender, EventArgs e)
        {

        }
    }
}
