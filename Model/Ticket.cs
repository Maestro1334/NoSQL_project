using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class Ticket
    {
        [BsonId]
        public BsonObjectId ID { get; set; }
        public string Subject { get; set; }
        public string Type { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string Priority { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public TicketStatus Status { get; set; }
        public string Feedback { get; set; }
    }
}
