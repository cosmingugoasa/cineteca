using System.Collections.Generic;
using System.ServiceModel;

namespace WCFServer
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IServerServices" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IServerServices
    {
        [OperationContract]
        bool DoWork();

        /*[OperationContract]
        bool NuovoUtente(int myId, string myNome, string myCognome, string myEmail, string myPassword, bool myIsAdmin);*/

        [OperationContract]
        string GetNomeUtente();

        [OperationContract]
        bool RegisterUser(string email, string passw, string nome, string cognome, int isAdmin);

        [OperationContract]
        bool LoginUser(string email, string passw);

        [OperationContract]
        List<Film> FilmsList();

    }
}
