using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    class Utente
    {
        private int Id;
        private String Nome;
        private String Cognome;
        private String Email;
        private String Password;
        private String IsAdmin;

        public Utente() { }

        public Utente(int myId, string myNome, string myCognome, string myEmail, string myPassword, string myIsAdmin)
        {
            Id = myId;
            Nome = myNome;
            Cognome = myCognome;
            Email = myEmail;
            Password = myPassword;
            IsAdmin = myIsAdmin;
        }

        public string nome
        {
            get
            {
                return this.Nome;
            }
            set
            {
                this.Nome = value;
            }
        }

        public int id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }

        public string cognome
        {
            get
            {
                return this.Cognome;
            }
            set
            {
                this.Cognome = value;
            }
        }

        public string email
        {
            get
            {
                return this.Email;
            }
            set
            {
                this.Email = value;
            }
        }
        public string password
        {
            get
            {
                return this.Password;
            }
            set
            {
                this.Password = value;
            }
        }
        public string isAdmin
        {
            get
            {
                return this.IsAdmin;
            }
            set
            {
                this.IsAdmin = value;
            }
        }

    }
}
