using PostboxCommunicator.Helpers;
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






        private void FeedbackView_Load(object sender, EventArgs e)
        {

        }
    }
}
