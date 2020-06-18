using System;
using System.Security.Cryptography;

namespace Logic
{
    public static class PasswordHasher
    {
        private const int SALTSIZE = 16;
        private const int HASHSIZE = 20;

        /// <summary>
        /// Creates a hash from a password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <param name="iterations">Number of iterations.</param>
        /// <returns>hash</returns>
        public static string Hash(string password, int iterations)
        {
            // Create salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[SALTSIZE]);

            // Create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(HASHSIZE);

            // Combine salt and hash
            var hashBytes = new byte[SALTSIZE + HASHSIZE];
            Array.Copy(salt, 0, hashBytes, 0, SALTSIZE);
            Array.Copy(hash, 0, hashBytes, SALTSIZE, HASHSIZE);

            // Convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // Format hash with extra information
            return string.Format("$NOSQLPROJECT${0}${1}", iterations, base64Hash);
        }

        /// <summary>
        /// Creates a hash from a password with 10000 iterations
        /// </summary>
        /// <param name="password">The password</param>
        /// <returns>Hash string</returns>
        public static string Hash(string password)
        {
            return Hash(password, 10000);
        }

        /// <summary>
        /// Checks if hash is supported.
        /// </summary>
        /// <param name="hashString">The hash.</param>
        /// <returns>Bool True/False - Is the hasing method that is used on this hashed password supported?</returns>
        public static bool IsHashSupported(string hashString)
        {
            return hashString.Contains("$NOSQLPROJECT$");
        }
        
        /// <summary>
        /// Verifies a password against a hash.
        /// </summary>
        /// <param name="password">The password</param>
        /// <param name="hashedPassword">The hash</param>
        /// <returns>Bool true if matches</returns>
        public static bool Verify(string password, string hashedPassword)
        {
            // Check hash
            if (!IsHashSupported(hashedPassword))
            {
                throw new NotSupportedException("The hashtype is not supported");
            }

            // Extract iteration and Base64 string
            var splittedHashString = hashedPassword.Replace("$NOSQLPROJECT$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // Get hash bytes
            var hashBytes = Convert.FromBase64String(base64Hash);

            // Get salt
            var salt = new byte[SALTSIZE];
            Array.Copy(hashBytes, 0, salt, 0, SALTSIZE);

            // Create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(HASHSIZE);

            // Get result
            for (var i = 0; i < HASHSIZE; i++)
            {
                if (hashBytes[i + SALTSIZE] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }        
    }
}
