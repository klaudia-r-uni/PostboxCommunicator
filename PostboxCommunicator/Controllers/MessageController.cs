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
            newMessage.BorderStyle = BorderStyle.None; 

            //TODO - prevent resizing problems 
            newMessage.Width = panel.Width - 100;

            int messageLength = message.content.Length;

            int messageTextBoxWidth = newMessage.Width;
            double numberOfCharsPerLine = (double)messageTextBoxWidth / characterLength;
            int height = Convert.ToInt32((double)message.content.Length / (0.8 * numberOfCharsPerLine));

            newMessage.Height = (height * 10) + 20; 

            if( message.recipientId == ApplicationState.userId) {
                newMessage.Margin = new Padding(95, 10, 0, 0);
                //blue
                newMessage.BackColor = Color.FromArgb(255, 159, 170, 218);
            } else if ( message.senderId == ApplicationState.userId ) {
                newMessage.Margin = new Padding(10, 10, 0, 0);
                //yellow
                newMessage.BackColor = Color.FromArgb(255, 255, 250, 139);
            } 
            return newMessage;
        }
    }
}
