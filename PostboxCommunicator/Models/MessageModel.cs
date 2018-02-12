using System;

namespace PostboxCommunicator.Models {
    class MessageModel {
        public string content { get; set; }
        public DateTime dateTime { get; set; }
        public string recipientId { get; set; }
        public string senderId { get; set; }
    }
}
