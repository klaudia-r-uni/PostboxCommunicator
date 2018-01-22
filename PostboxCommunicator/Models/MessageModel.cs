using System;

namespace PostboxCommunicator.Models {
    class MessageModel {
        public string authorType { get; set; }
        public string content { get; set; }
        public DateTime dateTime { get; set; }
    }
}
