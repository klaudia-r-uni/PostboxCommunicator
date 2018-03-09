using PostboxCommunicator.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PostboxCommunicator
{
    public partial class FeedbackView : Form
    {
        public FeedbackView()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(255, 212, 213, 214);
            contentPanel.BackColor = Color.FromArgb(255, 159, 170, 218);

            messageContent.BackColor = Color.FromArgb(255, 255, 250, 139);
            messageContent.BorderStyle = BorderStyle.FixedSingle;

            //@TODO change to content
            messageContent.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vestibulum accumsan eros, quis sodales leo suscipit vel. Duis finibus dictum laoreet. Ut lobortis odio libero, a vulputate nibh mattis eget.";

            ViewHelper.centerTheTextBox(messageContent, contentPanel);
            ViewHelper.centerThePanel(contentPanel, this);
        }


        static FeedbackView MsgBox;
        ////////////////////////////////////////////////////////////////////////////////

        public static void Show(string Text, string Caption)
        {
            MsgBox = new FeedbackView();
            MsgBox.messageContent.Text = Text;
            MsgBox.Text = Caption;
            MsgBox.ShowDialog();
        }


        //Gets the message details that are to be displayed 

        public void setCustomizedMessage(string message) {
            this.messageContent.Text = message;
        }

        private void FeedbackView_Load(object sender, System.EventArgs e)
        {

        }
    }
}