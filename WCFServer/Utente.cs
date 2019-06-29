using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

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

        public Utente() {
   
        }

        public Utente(int myId, string myEmail, string myPassword, string myNome, string myCognome, bool myIsAdmin)
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

  
        public string GetEmail()
        {
            return email;
        }
    }
}
