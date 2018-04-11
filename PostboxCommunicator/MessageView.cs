using System.Windows.Forms;
using PostboxCommunicator.Models;
using System.Drawing;

namespace PostboxCommunicator {
    public partial class MessageView : UserControl {
        public MessageView(MessageModel message) {
            InitializeComponent();
            time.Text = message.dateTime;
            text.Text = message.content;
        }

        internal void SetColour(Color colour) {
            BackColor = colour;
            text.BackColor = colour;
        }
    }
}
