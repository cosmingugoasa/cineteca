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
        List<Film> StoreFilmsList();

        [OperationContract]
        Utente GetUser(string email);

        [OperationContract]
        bool RentFilm(int user_id, int film_id, string start_nol, string stop_nol);

        [OperationContract]
        bool SetFilmStatus(int film_id, bool disp);

        [OperationContract]
        List<Film> LibraryFilmsList(int user_id);

        [OperationContract]
        bool ReturnFilm(int user_id, int film_id);

        [OperationContract]
        bool InsertFilm(string titolo, string descrizione, bool disponibile, string url_image);

        [OperationContract]
        bool RemoveFilm(string titolo);

        [OperationContract]
        bool GetFilmDisp(int film_id);

    }
}
