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
            ClientServerCommunication server = ClientServerCommunication.getInstance();
            LoginModel user = new LoginModel();
            user.username = "user1";
            user.password = "user1";
            string error = server.login(user).Result;
            string users = server.getUsers().Result;

            NewMessageModel mess = new NewMessageModel();
            mess.sender = user.username;
            mess.receiver = "user2";
            mess.content = "this is a message";
            mess.dateTime = DateTime.Now;

            server.sendMessage(mess);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

    }
}
