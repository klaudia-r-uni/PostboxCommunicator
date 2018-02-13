using System;

namespace PostboxCommunicator.Models {
    public class MessageModel {
        public string recipientId { get; set; }
        public string senderId { get; set; }
        public string content { get; set; }
        public DateTime dateTime { get; set; }
    }
}
