using System;
using System.Runtime.Serialization;

namespace WCFServer
{
    [DataContract]
    public class Utente
    {
        [DataMember]
        private int id { get; }
        [DataMember]
        private String nome { get; }
        [DataMember]
        private String cognome { get; }
        [DataMember]
        private String email { get; }
        [DataMember]
        private String password { get; }
        [DataMember]
        private bool isAdmin { get; }

        public Utente() {}      //costruttore vuoto

        public Utente(int myId, string myEmail, string myPassword, string myNome, string myCognome, bool myIsAdmin)
        {
            id = myId;
            nome = myNome;
            cognome = myCognome;
            email = myEmail;
            password = myPassword;
            isAdmin = myIsAdmin;
        }
        
    }
}
