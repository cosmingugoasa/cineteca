using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        public String GetNomeUtente()
        {
            Utente utente_prova = new Utente("cosmin");
            return utente_prova.GetNome();
        }

        public bool RegisterUser(string email, string passw, string nome, string cognome, bool isAdmin)
        {
            MySqlConnection conn = new MySqlConnection("Server=mysql-loca.alwaysdata.net;Database=loca_cineteca;Uid=loca;Pwd=prova98;");
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("Connessione DB aperta\n");
            }
            else
            {
                Console.WriteLine("Connessione DB fallita\n");
            }

            try
            {
                string cmd_string = "INSERT INTO UTENTE (Email, Passw, Nome, Cognome, IsAdmin) VALUES ('" + email + "', '"+passw+"', '"+nome+"', '"+cognome+"', '"+isAdmin+"')";
                MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }        
    }
}
