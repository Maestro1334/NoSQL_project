using MongoDB.Bson;

namespace Model
{
    public class User
    {
        public BsonObjectId Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserType Type { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public int AmountOfIncidents { get; set; }
    }
}
