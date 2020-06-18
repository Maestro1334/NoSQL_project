using System.Collections.Generic;
using System.Linq;
using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DAL
{
    public class TicketDAO : Base
    {
        private readonly IMongoCollection<BsonDocument> ticketsCollection;
        private readonly IMongoCollection<BsonDocument> usersCollection;

        public TicketDAO()
        {
            ticketsCollection = database.GetCollection<BsonDocument>("incidents");
            usersCollection = database.GetCollection<BsonDocument>("users");
        }

        public List<BsonDocument> GetTickets()
        {
            string filter = "{}";
            return ticketsCollection.Find(filter).ToList();
        }

        public List<BsonDocument> GetTickets(string email)
        {
            string filter = "{user: '" + email + "'}";
            return ticketsCollection.Find(filter).ToList();
        }

        public BsonDocument GetTicket(string id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            return ticketsCollection.Find(filter).FirstOrDefault().ToBsonDocument();
        }

        public List<BsonDocument> FilterByEmailDB(string email)
        {
            string filter = "{email: '" + email + "'}";
            return ticketsCollection.Find(filter).ToList();
        }

        public async void AddTicket(BsonDocument ticket, string email)
        {
            using (var session = await client.StartSessionAsync())
            {
                // Begin transaction
                session.StartTransaction();

                try
                {
                    // Insert incident ticket
                    await ticketsCollection.InsertOneAsync(ticket);
                    
                    // Update amount of incidents user has inserted
                    var filter = Builders<BsonDocument>.Filter.Eq("email", email);
                    var update = Builders<BsonDocument>.Update.Set("number_of_incidents", +1);
                    await usersCollection.UpdateOneAsync(filter, update);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error writing to MongoDB: " + e.Message);
                    await session.AbortTransactionAsync();
                }

                // Commit the transaction
                await session.CommitTransactionAsync();
            }
        }

        public void ReplaceTicket(string id, BsonDocument ticket)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            ticketsCollection.ReplaceOne(filter, ticket);
            
        }

        public async void RemoveTicket(string id, string email)
        {
            using (var session = await client.StartSessionAsync())
            {
                // Begin transaction
                session.StartTransaction();

                try
                {
                    var filterIncident = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
                    // Delete incident ticket
                    await ticketsCollection.DeleteOneAsync(filterIncident);

                    // Update amount of incidents user has inserted
                    var filterUser = Builders<BsonDocument>.Filter.Eq("email", email);
                    var update = Builders<BsonDocument>.Update.Set("number_of_incidents", -1);
                    await usersCollection.UpdateOneAsync(filterUser, update);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error writing to MongoDB: " + e.Message);
                    await session.AbortTransactionAsync();
                }

                // Commit the transaction
                await session.CommitTransactionAsync();
            }
        }        
    }
}
