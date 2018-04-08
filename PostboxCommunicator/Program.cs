using System;
using System.Windows.Forms;
using PostboxCommunicator.Infrastructure;

namespace PostboxCommunicator {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ClientServerCommunication server = ClientServerCommunication.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInView());
        }

    }
}