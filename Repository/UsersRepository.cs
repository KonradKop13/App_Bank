using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Users;
using APPbank.Forms;
using System.Runtime.CompilerServices;

namespace APPbank.Repository
{
   
    [Serializable]
    internal class UsersRepository
    {
        public List<User> Users { get; set; }


        [NonSerialized] private Session _session = Session.GetInstance();


        // Konstruktor klasy UsersRepository

       
        
        public UsersRepository()
        {
            Users = new List<User>();
        }
       



        // Funkcja przypisująca liście kont zawartej w repozytorium użytkowników nową listę kont

        public void UpdateUsersList(List<User> usersList)
        {
            Users = usersList;
        }

        public static UsersRepository? UsersRepositoryInstance;

        
         // Funkcja zwracająca istniejącą instancję repozytorium użytkowników lub pobiera ją z pliku w przypadku braku istniejącej instancji 
         
        public static UsersRepository GetInstance()
        {
            if (UsersRepositoryInstance == null)
            {
                //UsersRepositoryInstance = new UsersRepository();
                UsersRepositoryInstance = FileHandler<UsersRepository>.ReadFromJsonFile<UsersRepository>("UserBase.json");
            }
            return UsersRepositoryInstance;
        }
       
        
        // Funkcja dodająca nowy obiekt klasy User do repozytorium użytkowników
         
        public void AddUser(User user)
        {
            Users.Add(user);
        }

        
        // Funkcja usuwająca użytkownika z repozytorium użytkowników
        
        public void DeleteUserByLogin(string login)
        {
            
            foreach (User user in Users)
            {
                if (user.Login == login)
                {
                    if (user.accountsList != null)
                    {
                       
                        user.accountsList.Clear();
                        Users.Remove(user);
                        MessageBox.Show("Usunięto użytkownika z bazy");
                        return;
                    }

                    Users.Remove(user);
                    MessageBox.Show("Usunięto użytkownika z bazy");
                    return;
                }
            }
            MessageBox.Show("Nie znaleziono użytkownika");
           

        }


      
         // Funkcja sprawdzająca, czy dany użytkownik istnieje w repozytorium
        
        public bool Exists(string login)
        {
            foreach (User u in Users)
            {
                if (login == u.Login)
                {
                    return true;
                }
            }

            return false;
        }

        
        // Funkcja przypisująca użytkownika do sesji w przypadku poprawnych danych logowania
        
        public bool TryToLogin(string login, string password)
        {
            foreach (User user in Users)
            {
                if (user.Login == login)
                {
                    if (user.Password == password)
                    {
                        _session.SetSessionMaster(user);
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CheckAdmin(string login)
        {
            foreach (User user in Users)
            {
                if (user.Login == login)
                {
                    if (user is Admin)
                    {
                        return true;
                    }

                    return false;
                }
            }
            return false;
        }

       

    }
}
