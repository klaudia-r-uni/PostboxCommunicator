using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostboxCommunicator.Models {
    class NewMessageModel {
        public string sender { get; set; }
        public string receiver { get; set; }
        public string content { get; set; }
        public DateTime dateTime { get; set; }
    }
}
