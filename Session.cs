using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPbank.Users;

namespace APPbank
{
    internal class Session
    {
    
    // Konstruktor klasy Session
    
        private Session()
        {
            SessionMaster = null;
        }

        private static Session? _sessionInstance;

        
         // Funkcja pobierająca instancję istniejącego obiektu Session lub tworząca ją w przypadku braku tej instancji
         
        public static Session GetInstance()
        {
            if (_sessionInstance == null)
            {
                _sessionInstance = new Session();
            }

            return _sessionInstance;
        }

        public User? SessionMaster;

        
         // Funkcja ustawiająca właściciela sesji
        
        public void SetSessionMaster(User sessionMaster)
        {
            SessionMaster = sessionMaster;
        }

        
         // Funkcja usuwająca właściciela sesji
         
        public void LogOffSessionMaster()
        {
            SessionMaster = null;
        }

        public string Show()
        {
            return SessionMaster.Login.ToString();
        }
    }
}
