using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServer
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServerServices" nel codice e nel file di configurazione contemporaneamente.
    public class ServerServices : IServerServices
    {
        public bool DoWork()        //usata solo per controllare connettivita' dal client 
        {
            return true;
        }

        public bool NuovoUtente(int myId, string myNome, string myCognome, string myEmail, string myPassword, bool myIsAdmin) {

            Utente prova = new Utente(myId, myNome, myCognome, myEmail, myPassword, myIsAdmin); //Creo l'utene, ma prima dovremmo fare oppurtuni controlli nel database e poi TRY & CATCH 

            if (prova != null)
                return true;
            else
                return false;
        }


    }
}
