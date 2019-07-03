using System;
using System.Runtime.Serialization;

namespace WCFServer
{
    [DataContract]
    public class Utente
    {
        [DataMember]
        private int id { get; set; }
        [DataMember]
        private String nome { get; set; }
        [DataMember]
        private String cognome { get; set; }
        [DataMember]
        private String email { get; set; }
        [DataMember]
        private String password { get; set; }
        [DataMember]
        private bool isAdmin { get; set; }

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
