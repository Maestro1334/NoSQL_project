using Model;
using DAL;
using MongoDB.Bson;
using System.Collections.Generic;
using System;

namespace Logic
{
    public class TicketService
    {
        private TicketDAO ticketDAO;

        public TicketService()
        {
            this.ticketDAO = new TicketDAO();
        }

        public List<Ticket> GetTickets()
        {
            try
            {
                List<BsonDocument> ticketDocuments = ticketDAO.GetTickets();
                List<Ticket> tickets = new List<Ticket>(); ;

                foreach (BsonDocument userDocument in ticketDocuments)
                {
                    Ticket ticket = new Ticket()
                    {
                        ID = (BsonObjectId)userDocument.GetValue("_id"),
                        Subject = userDocument.GetValue("subject").ToString(),
                        Type = userDocument.GetValue("type").ToString(),
                        User = userDocument.GetValue("user").ToString(),
                        Priority = userDocument.GetValue("priority").ToString(),
                        Date = (DateTime)userDocument.GetValue("date"),
                        Status = CheckStatus(userDocument.GetValue("status").ToInt32()),
                        Deadline = (DateTime)userDocument.GetValue("deadline"),
                        Description = userDocument.GetValue("description").ToString(),
                    };

                    tickets.Add(ticket);
                }

                return tickets;
            }
            catch
            {
                return null;
            }
        }

        public List<Ticket> GetTickets(string userEmail)
        {
            try
            {
                List<BsonDocument> ticketDocuments = ticketDAO.GetTickets(userEmail);
                List<Ticket> tickets = new List<Ticket>();

                foreach (BsonDocument userDocument in ticketDocuments)
                {
                    Ticket ticket = new Ticket()
                    {
                        ID = (BsonObjectId)userDocument.GetValue("_id"),
                        Subject = userDocument.GetValue("subject").ToString(),
                        Type = userDocument.GetValue("type").ToString(),
                        User = userDocument.GetValue("user").ToString(),
                        Priority = userDocument.GetValue("priority").ToString(),
                        Date = (DateTime)userDocument.GetValue("date"),
                        Status = CheckStatus(userDocument.GetValue("status").ToInt32()),
                        Deadline = (DateTime)userDocument.GetValue("deadline"),
                        Description = userDocument.GetValue("description").ToString(),
                    };

                    tickets.Add(ticket);
                }

                return tickets;
            }
            catch
            {
                return null;
            }
        }

        public Ticket GetTicket(string id)
        {
            try
            {
                BsonDocument ticketDoc = ticketDAO.GetTicket(id);

                return new Ticket()
                {
                    ID = (BsonObjectId)ticketDoc.GetValue("_id"),
                    Subject = ticketDoc.GetValue("subject").ToString(),
                    Type = ticketDoc.GetValue("type").ToString(),
                    User = ticketDoc.GetValue("user").ToString(),
                    Priority = ticketDoc.GetValue("priority").ToString(),
                    Date = (DateTime)ticketDoc.GetValue("date"),
                    Status = CheckStatus(ticketDoc.GetValue("status").ToInt32()),
                    Deadline = (DateTime)ticketDoc.GetValue("deadline"),
                    Description = ticketDoc.GetValue("description").ToString(),
                };
            }
            catch
            {
                return null;
            }
        }



        private TicketStatus CheckStatus(int value)
        {
            if (Enum.IsDefined(typeof(TicketStatus), value))
            {
                return (TicketStatus)value;
            }
            else
            {
                throw new ArgumentException("Ticket database status out of range for enum");
            }
        }

        public void AddTicket(Ticket ticket)
        {
            BsonDocument ticketDocument = new BsonDocument
            {
                {"date", ticket.Date },
                {"subject", ticket.Subject },
                {"type", ticket.Type},
                {"user", ticket.User },
                {"priority", ticket.Priority },
                {"deadline", ticket.Deadline },
                {"description", ticket.Description },
                {"status", 0 },
            };

            ticketDAO.AddTicket(ticketDocument, ticket.User);
        }

        public void ReplaceTicket(string id, Ticket ticket)
        {
            BsonDocument ticketDocument = new BsonDocument
            {
                {"date", ticket.Date },
                {"subject", ticket.Subject },
                {"type", ticket.Type},
                {"user", ticket.User },
                {"priority", ticket.Priority },
                {"deadline", ticket.Deadline },
                {"description", ticket.Description },
                {"status", ticket.Status },
            };

            ticketDAO.ReplaceTicket(id, ticketDocument);
        }

        public void SendFeedback(string id, Ticket ticket)
        {
            BsonDocument ticketDocument = new BsonDocument
            {
                {"date", ticket.Date },
                {"subject", ticket.Subject },
                {"type", ticket.Type},
                {"user", ticket.User },
                {"priority", ticket.Priority },
                {"deadline", ticket.Deadline },
                {"description", ticket.Description },
                {"status", ticket.Status },
                {"feedback", ticket.Feedback }
            };

            ticketDAO.ReplaceTicket(id, ticketDocument);
        }

        public void RemoveTicket(string id, string email)
        {
            ticketDAO.RemoveTicket(id, email);
        }
    }
}
