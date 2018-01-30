using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostboxCommunicator {
    public class ApplicationState {

        private const string user = "Harry Potter";
        public const string userId = "HarryPotter";

        public static string getUserName() {
            return user; 
        }
    }
}
