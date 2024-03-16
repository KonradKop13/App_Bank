using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Repository;
using APPbank.Forms;

namespace APPbank.FunctionalModules
{
    internal class MLogin
    {
        private UsersRepository _usersRepository = UsersRepository.GetInstance();
        private readonly string _login;
        private readonly string _password;

        
         // Konstruktor obiektu MLogin
        
        public MLogin(string login, string password)
        {
            _login = login;
            _password = password;
        }

        
         // Funkcja przekazująca informacje przekazane w konstruktorze do funkcji przypisującej użytkownika do sesji, o ile podane inforamcje są poprawne
         
        public bool Execute()
        {
            

            if (_usersRepository.TryToLogin(_login, _password))
            {
                MessageBox.Show("Logowanie zakończone powodzeniem");
                return true;
            }
            else
            {
                 MessageBox.Show("Logowanie nie powiodło się");
                return false;
            }

          
        }

        public bool IsThisAnAdmin ()
        {


            if (_usersRepository.CheckAdmin(_login))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
