using Project13InsuranceManagement.DataLayer;
using System;
using System.Collections.Generic;

namespace Project13InsuranceManagement.IdentityManagement
{
    [Serializable]
    public class User : ObjectPlus
    {
        public String UserName { get; set; }
        //PasswordHash (ale tylko readonly)
        public String PasswordHash { get; private set; }
        public List<Rental> Rentals { get; private set; } = new List<Rental>();
        //Password ale tylko z setterem(ustawia PasswordHash)
        public String Password
        {
            set
            {
                PasswordHash = Utility.Cryptography.sha256(value);
            }
        }

        public User(String userName, String password)
        {
            UserName = userName;
            Password = password;
        }

        public bool ValidatePassword(String password)
        {
            password = Utility.Cryptography.sha256(password);
            return PasswordHash.Equals(password);
        }

        public override string ToString()
        {
            return UserName;
        }
    }
}