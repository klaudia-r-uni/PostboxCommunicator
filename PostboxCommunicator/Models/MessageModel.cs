using System;

namespace PostboxCommunicator.Models {
    public class MessageModel {
        public int id { get; set; }
        public string recipientId { get; set; }
        public string senderId { get; set; }
        public string content { get; set; }
        public string dateTime { get; set; }
    }
}
