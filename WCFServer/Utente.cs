using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    
    public class Utente
    {
        private int id;
        private String nome;
        private String cognome;
        private String email;
        private String password;
        private bool isAdmin;

        public Utente() { }

        public Utente(int myId, string myNome, string myCognome, string myEmail, string myPassword, bool myIsAdmin)
        {
            id = myId;
            nome = myNome;
            cognome = myCognome;
            email = myEmail;
            password = myPassword;
            isAdmin = myIsAdmin;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return this.cognome;
            }
            set
            {
                this.cognome = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return this.isAdmin;
            }
            set
            {
                this.isAdmin = value;
            }
        }

    }
}
