using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using SuperFlightsApp.Model;
using SuperFlightsApp.Repository;

namespace SuperFlightsApp.Services
{
    public class Service
    {
        private readonly IRepoUsers repoUsers;
        private readonly IRepoFlights repoFlights;
        private readonly IRepoTickets repoTickets;

        public Service(IRepoUsers repoUsers, IRepoFlights repoFlights, IRepoTickets repoTickets) 
        {
            this.repoUsers = repoUsers;
            this.repoFlights = repoFlights;
            this.repoTickets = repoTickets;
        }

        public void Login(User loggedUser)
        { 
            User? user = repoUsers.GetUserByEmail(loggedUser.Email);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            //Hash password
            string hashedPassword = HashPassword(loggedUser.Password, user.Salt);
            if(hashedPassword != user.Password)
            {
                throw new Exception("Wrong password");
            }
        }

        //no salt generated and no hashing until here
        public void SignUp(User newUser)
        {
            //Check User
            if (!newUser.Email.Contains('@'))
            {
                throw new Exception("Invalid email");
            }
            else if (newUser.Password.Length < 8)
            {
                throw new Exception("Password must be at least 8 characters long");
            }

            //Generate salt
            byte[] salt = GenerateSalt();
            newUser.Salt = salt;

            //Hash password
            string hashedPassword = HashPassword(newUser.Password, salt);
            newUser.Password = hashedPassword;

            //Add user to repo
            long id = repoUsers.AddEntity(newUser);
            if (id == -1)
            {
                throw new Exception("User already exists");
            }
        }

        public byte[] GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return salt;
        }

        public static string HashPassword(string password, byte[] salt)
        {

            // Generate the hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(20);

            // Combine the salt and hash
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convert to base64 for storage
            return Convert.ToBase64String(hashBytes);
        }

    }
}
