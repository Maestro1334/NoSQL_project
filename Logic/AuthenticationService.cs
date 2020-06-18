using System;
using Model;
using DAL;
using MongoDB.Bson;
using System.Windows.Forms;
using System.Web.Security;

namespace Logic
{
    public class AuthenticationService
    {
        private readonly UserDAO userDAO;
        private User user;
        private static AuthenticationService authenticationService;

        private AuthenticationService()
        {
            this.userDAO = new UserDAO();
        }

        public static AuthenticationService GetInstance()
        {
            if (authenticationService == null)
            {
                authenticationService = new AuthenticationService();
            }

            return authenticationService;
        }

        /// <summary>
        /// Login method that checks if the password is correct and creates a new user with the user details from the database and saves it for future use
        /// </summary>
        /// <param name="username">Username/Email</param>
        /// <param name="password">Password</param>
        /// <returns>true if password match else return false and an error message if needed</returns>
        public bool Login(string username, string password, out string error)
        {
            this.user = null;

            try
            {
                BsonDocument unverifiedUser = userDAO.GetUser(username);

                if (PasswordHasher.Verify(password, (string)unverifiedUser.GetValue("password")))
                {
                    user = new User()
                    {
                        Id = (BsonObjectId)unverifiedUser.GetValue("_id"),
                        Email = unverifiedUser.GetValue("email").ToString(),
                        FirstName = unverifiedUser.GetValue("first_name").ToString(),
                        LastName = unverifiedUser.GetValue("last_name").ToString(),
                        Type = (UserType)unverifiedUser.GetValue("type").ToInt32(),
                        PhoneNumber = unverifiedUser.GetValue("phone_number").ToString(),
                        Location = unverifiedUser.GetValue("location").ToString(),
                        AmountOfIncidents = unverifiedUser.GetValue("number_of_incidents").ToInt32()
                    };

                } else
                {
                    error = "";
                    return false;                    
                }
            }
            catch
            {
                error = "This email address does not have an account attached to it";
                return false;
            }

            error = "";
            return true;
        }

        /// <summary>
        /// Check if user is logged in
        /// </summary>
        /// <returns>true if if logged in else false</returns>
        public bool IsLoggedIn()
        {
            return user != null;
        }

        /// <summary>
        /// Get the current user logged in user information
        /// </summary>
        /// <returns>Class User with the user information</returns>
        public User GetCurrentUser()
        {
            return user;
        }

        /// <summary>
        /// Check if the logged in user is an employee
        /// </summary>
        /// <returns>true if is an empoyee else false</returns>
        public bool IsEmployee()
        {
            if (user.Type == UserType.Employee)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if the email has an account attached to it
        /// </summary>
        /// <param name="email">Username/Email</param>
        /// <returns>true if email exists in database else false</returns>
        public bool CheckEmailStatus(string email)
        {
            try
            {
                if (userDAO.GetUser(email) != null)
                {
                    return true;
                } else
                {
                    return false;
                }                
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Request reset code and insert that code with an expiration date into the database
        /// </summary>
        /// <param name="email">Username/Email</param>
        public void RequestResetCode(string email)
        {
            // Create a random code with a length of 6
            Random random = new Random();
            int randomNumber = random.Next(1, 1000000);
            string code = randomNumber.ToString().PadLeft(6, '0');            

            try
            {
                // Add new reset request to the database
                userDAO.UpdateResetRequestCode(DateTime.Now.AddDays(1), code, email);
                Emailer.SendMail(email, "Your password reset request for NoDesk", $"Your password reset code is: {code}");
            }
            catch
            {
                MessageBox.Show("Error while creating your reset code, try again");
            }            
        }

        /// <summary>
        /// Reset user password if the code that was emailed was correctly matched to the one in the database
        /// </summary>
        /// <param name="email">Username/Email</param>
        /// <param name="code">Code from email</param>
        /// <returns>true if password changed else false</returns>
        public bool ResetPassword(string email, string code)
        {
            try
            {
                // Get request from database by email
                BsonDocument request = userDAO.GetUser(email);

                // Check if code was requested
                if (request.GetValue("token") != null)
                {
                    // Check if it is expired
                    if (DateTime.Now < request.GetValue("expiration_date"))
                    {
                        if (request.GetValue("token") == code)
                        {
                            // Generate random password with 2 non-alphanumeric characters 
                            string password = Membership.GeneratePassword(8, 2);

                            // Send email with the new password
                            Emailer.SendMail(email, "Your new password for NoDesk", $"Your new password is: {password}");

                            // Hash password
                            string hashedPassword = PasswordHasher.Hash(password);

                            // Update the password in the database
                            userDAO.UpdatePassword(email, hashedPassword);

                            // Remove used reset request
                            userDAO.RemoveResetRequest(email);

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    } else
                    {
                        MessageBox.Show("Your code has expired, please request a new one");
                        return false;
                    }  
                } else
                {
                    MessageBox.Show("You have not requested a code yet, please try again or wait a couple of minutes.");
                    return false;
                }   
            }
            catch
            {
                MessageBox.Show("Error while resetting your password, try again");
                return false;
            } 
        }

        /// <summary>
        /// Removes the user information from the service (logout)
        /// </summary>
        public void Logout()
        {
            this.user = null;
        }
    }
}
