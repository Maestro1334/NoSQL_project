using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;


namespace DAL
{
    public class UserDAO : Base
    {
        private readonly IMongoCollection<BsonDocument> usersCollection;

        public UserDAO()
        {
            usersCollection = database.GetCollection<BsonDocument>("users");
        }

        public BsonDocument GetUser(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("email", username);
            return usersCollection.Find(filter).FirstOrDefault().ToBsonDocument();
        }

        public async void UpdateResetRequestCode(DateTime expirationDate, string code, string email)
        {
            using (var session = await client.StartSessionAsync())
            {
                // Begin transaction
                session.StartTransaction();

                try
                {
                    // Add expiration date for code to user
                    var filter = Builders<BsonDocument>.Filter.Eq("email", email);
                    var update = Builders<BsonDocument>.Update.Set("expiration_date", expirationDate);
                    usersCollection.UpdateOne(filter, update);

                    // Add the code to user
                    var filterCode = Builders<BsonDocument>.Filter.Eq("email", email);
                    var updateCode = Builders<BsonDocument>.Update.Set("token", code);
                    usersCollection.UpdateOne(filterCode, updateCode);
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

        public async void RemoveResetRequest(string email)
        {
            using (var session = await client.StartSessionAsync())
            {
                // Begin transaction
                session.StartTransaction();

                try
                {
                    // Unset email field
                    var filter = Builders<BsonDocument>.Filter.Eq("email", email);
                    var update = Builders<BsonDocument>.Update.Unset("expiration_date");
                    usersCollection.UpdateOne(filter, update);

                    // Unset token field
                    var filterCode = Builders<BsonDocument>.Filter.Eq("email", email);
                    var updateCode = Builders<BsonDocument>.Update.Unset("token");
                    usersCollection.UpdateOne(filterCode, updateCode);
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

        public void UpdatePassword(string email, string password)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("email", email);
            var update = Builders<BsonDocument>.Update.Set("password", password);
            usersCollection.UpdateOne(filter, update);
        }

        public void AddUser(BsonDocument user)
        {
            usersCollection.InsertOne(user);
        }

        public List<BsonDocument> GetUsers()
        {
            string filter = "{}";
            return usersCollection.Find(filter).ToList();
        }
    }
}
