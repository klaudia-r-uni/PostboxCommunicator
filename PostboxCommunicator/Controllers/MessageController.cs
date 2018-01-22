using PostboxCommunicator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostboxCommunicator.Controllers {
    class MessageController {
        public const double characterLength = 4.75;

        public TextBox getMessageBox(MessageModel message, FlowLayoutPanel panel) {
            TextBox newMessage = new TextBox();
            newMessage.Text = message.content;
            newMessage.ReadOnly = true;
            newMessage.Multiline = true;
            newMessage.TabStop = false;
            newMessage.WordWrap = true;
            newMessage.ScrollBars = ScrollBars.Vertical;
            newMessage.BorderStyle = BorderStyle.FixedSingle; 
            //TODO - prevent resizing problems 
            newMessage.Width = panel.Width - 100;

            int messageLength = message.content.Length;

            int messageTextBoxWidth = newMessage.Width;
            double numberOfCharsPerLine = (double)messageTextBoxWidth / characterLength;
            int height = Convert.ToInt32((double)message.content.Length / numberOfCharsPerLine);

            newMessage.Height = (height * 10) + 20; 

            if( message.authorType != "user") {
                newMessage.Margin = new Padding(95, 0, 0, 0);
                newMessage.BackColor = Color.FromArgb(255, 159, 170, 218);
            } else {
                newMessage.BackColor = Color.FromArgb(255, 255, 250, 139);
            }
            return newMessage;
        }
    }
}
