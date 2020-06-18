using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public abstract class Base
    {
        protected readonly MongoClient client;
        protected readonly IMongoDatabase  database;

        public Base()
        {
            client = new MongoClient("mongodb+srv://622948:TiRgZf5TdqEsevc2@mbmdb-9r6ws.mongodb.net/test?retryWrites=true&w=majority");
            database = client.GetDatabase("Project_NoSQL");            
        }
    }
}
