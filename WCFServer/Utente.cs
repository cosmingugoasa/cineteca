using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    [DataContract]
    public class Utente
    {
        private int id;
        private String nome;
        private String cognome;
        private String email;
        private String password;
        private bool isAdmin;

        public Utente(string myNome) {
            nome = myNome;
        }

        public Utente(int myId, string myNome, string myCognome, string myEmail, string myPassword, bool myIsAdmin)
        {
            id = myId;
            nome = myNome;
            cognome = myCognome;
            email = myEmail;
            password = myPassword;
            isAdmin = myIsAdmin;
        }

        public string GetNome()
        {
            return nome;
        }
    }
}
