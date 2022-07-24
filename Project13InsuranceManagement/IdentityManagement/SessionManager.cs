using System;
using System.Linq;
using Project13InsuranceManagement.DataLayer;
using Project13InsuranceManagement.IdentityManagement;

namespace Project13InsuranceManagement.Session
{
    public class SessionManagerService
    {
        public static SessionManagerService Instance { get; private set; } = new SessionManagerService();
        private SessionManagerService() { }
        //singleton to taka klasa ktorej istnieje tylko jedna instancja w calym programie
        //prywatny konsturktor + prywatne klasowe pole przetrzymujace pojedyncza instancje + wlasciwosc klasowa readonly zwracajaca te pojedyncza instancje
        public User CurrentUser { get; private set; }

        public bool LogIn(String userName, String password)
        {
            var foundUser = ObjectPlus.Objects[typeof(User)].Cast<User>().Where(user => user.UserName == userName).FirstOrDefault();
            if (foundUser == null)
            {
                return false;
            }
            if (foundUser.ValidatePassword(password))
            {
                CurrentUser = foundUser;
                return true;
            }
            return false;
        }

        public void LogOut()
        {
            CurrentUser = null;
        }

        public bool isLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}