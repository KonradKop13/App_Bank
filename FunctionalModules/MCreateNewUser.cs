using APPbank.Repository;
using APPbank.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace APPbank.FunctionalModules
{
    internal class MCreateNewUser : IModule
    {
        private readonly UsersRepository _usersRepository = UsersRepository.GetInstance();
        private readonly string _login;
        private readonly string _password;
        private readonly bool _createNewAdmin;


        //Konstruktor obiektu MCreateNewUser
        public MCreateNewUser(string login, string password, bool createNewAdmin)
        {
            _login = login;
            _password = password;
            _createNewAdmin = createNewAdmin;
        }

        public void Execute()
        {
            string information;
            if (_usersRepository.Exists(_login))
            {
                information = "Ten użytkownik już istnieje";
                MessageBox.Show(information);
            }
            else if (_createNewAdmin)
            {
                User user = new Admin(_login, _password);
                _usersRepository.AddUser(user);
                information = "Konto z uprawnieniami administratora utworzone pomyślnie";
                MessageBox.Show(information);
            }
            else
            {
                User user = new Client(_login, _password);
                _usersRepository.AddUser(user);
                information = "Konto utworzone pomyślnie";
                MessageBox.Show(information);
            }



            
        }
       
    }
}
