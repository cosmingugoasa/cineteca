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
    }
}
