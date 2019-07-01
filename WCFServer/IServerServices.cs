using System;
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

        [OperationContract]
        bool RegisterUser(string email, string passw, string nome, string cognome, int isAdmin);

        [OperationContract]
        bool LoginUser(string email, string passw);

        [OperationContract]
        List<Film> FilmsList();

        [OperationContract]
        Utente GetUser(string email);

        [OperationContract]
        bool RentFilm(int user_id, int film_id, string start_nol, string stop_nol);

        [OperationContract]
        bool SetDispZero(int film_id);
    }
}
