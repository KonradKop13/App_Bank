using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using APPbank.Users;

namespace APPbank
{
    internal class MChangePassword
    {
        private readonly User _user;
        private readonly string _password;

        public MChangePassword(User user, string password)
        {
            _user = user;
            _password = password;
        }

        //Funkcja zmieniające hasło użytkownika na to podane w konstruktorze
    
        public void Execute()
        {
            _user.Password = _password;
        }
    }
}
