using Model;
using DAL;
using MongoDB.Bson;
using System.Web.Security;
using System.Collections.Generic;

namespace Logic
{
    public class UserService
    {
        private readonly UserDAO userDAO;

        public UserService()
        {
            this.userDAO = new UserDAO();
        }

        public void AddUser(User user, bool sendPassword)
        {
            // Generate random password with 2 non-alphanumeric characters 
            string password = Membership.GeneratePassword(8, 2);

            // Check if the user checked the send password button
            if (sendPassword)
            {
                // Send email with the new password
                Emailer.SendMail(user.Email, "Your new password for NoDesk", $"Your new password is: {password}");
            }

            // Hash password
            string hashedPassword = PasswordHasher.Hash(password);

            // Create bsondocument with user information
            BsonDocument userDoc = new BsonDocument
            {
                { "email", user.Email },
                { "first_name", user.FirstName },
                { "last_name", user.LastName },
                { "type", user.Type },
                { "phone_number", user.PhoneNumber },
                { "location", user.Location },
                { "number_of_incidents", 0 },
                { "password", hashedPassword }
            };

            // Add user doc to the database
            userDAO.AddUser(userDoc);
        }

        public bool IsRegistered(string email)
        {
            // Check if the email already has an account attached to it
            if (userDAO.GetUser(email) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckPassword(string username, string password)
        {
            try
            {
                BsonDocument unverifiedUser = userDAO.GetUser(username);

                if (!PasswordHasher.Verify(password, (string)unverifiedUser.GetValue("password")))
                {
                    return false;
                }
            }
            catch
            {                
                return false;
            }

            return true;
        }

        public bool ChangePassword(string username, string password)
        {
            string hashedPassword = PasswordHasher.Hash(password);

            try
            {
                userDAO.UpdatePassword(username, hashedPassword);                
            }
            catch
            {
                return false;
            }

            return true;
        }

        public List<User> GetUsers()
        {
            try
            {
                List<BsonDocument> usersDocument = userDAO.GetUsers();
                List<User> users = new List<User>(); ;

                foreach (BsonDocument userDocument in usersDocument)
                {
                    User user = new User()
                    {
                        Id = (BsonObjectId)userDocument.GetValue("_id"),
                        Email = userDocument.GetValue("email").ToString(),
                        FirstName = userDocument.GetValue("first_name").ToString(),
                        LastName = userDocument.GetValue("last_name").ToString(),
                        Type = (UserType)userDocument.GetValue("type").ToInt32(),
                        PhoneNumber = userDocument.GetValue("phone_number").ToString(),
                        Location = userDocument.GetValue("location").ToString(),
                        AmountOfIncidents = userDocument.GetValue("number_of_incidents").ToInt32()
                    };

                    users.Add(user);
                }

                return users;
            }
            catch
            {
                return null;
            }
        }
    }
}
