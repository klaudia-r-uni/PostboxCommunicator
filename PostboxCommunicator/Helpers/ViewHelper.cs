using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace PostboxCommunicator.Helpers {
    class ViewHelper {
        public static void centerThePanel(Panel panel, Form client) {
            panel.Location = new Point(
               client.ClientSize.Width / 2 - panel.Size.Width / 2,
               client.ClientSize.Height / 2 - panel.Size.Height / 2
            );
        }

        internal static void centerTheTextBox(RichTextBox messageContent, Panel contentPanel) {
            messageContent.Location = new Point(
                    contentPanel.Size.Width / 2 - messageContent.Size.Width / 2,
                      contentPanel.Size.Height / 2 - messageContent.Size.Height / 2
                ); 
        }
    }
}
