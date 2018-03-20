using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostboxCommunicator.Infrastructure;
using PostboxCommunicator.Models;

namespace PostboxCommunicator {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ClientServerCommunication server = ClientServerCommunication.Instance;
            
            
                        
            
//                        MessageModel mess = new MessageModel();
//                        mess.senderId = user.username;
//                        mess.recipientId = "user2";
//                        mess.content = "demo for Klaudia";
//                        mess.dateTime = DateTime.Now;
//            
//                        server.sendMessage(mess);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInView());
        }

    }
}