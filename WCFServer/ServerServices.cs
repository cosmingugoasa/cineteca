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
        MySqlConnection conn = new MySqlConnection("Server=mysql-loca.alwaysdata.net;Database=loca_cineteca;Uid=loca;Pwd=prova98;");


        public bool DoWork()        //usata solo per controllare connettivita' dal client 
        {
            return true;
        }


        public Utente GetUser(string email)
        {

            Utente myUtente;
            try
            {
                conn.Open();

                string strQuery = "SELECT * FROM UTENTE where email = '" + email + "'";
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    myUtente = new Utente(Convert.ToInt32(reader["Id"]), reader["Email"].ToString(), reader["Passw"].ToString(), reader["Nome"].ToString(), reader["Cognome"].ToString(), Convert.ToBoolean(reader["IsAdmin"]));
                    return myUtente;
                }

                conn.Close();
                return myUtente = new Utente();
            }
            catch
            {
                conn.Close();
                return myUtente = new Utente();
            }
        }

        public bool RegisterUser(string email, string passw, string nome, string cognome, int isAdmin)
        {
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("Connessione DB aperta\n");
                try
                {
                    string cmd_string = "INSERT INTO UTENTE (Email, Passw, Nome, Cognome, IsAdmin) VALUES ('" + email + "', '" + passw + "', '" + nome + "', '" + cognome + "', '" + isAdmin + "')";
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    conn.Dispose();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    conn.Close();
                    conn.Dispose();
                    return false;
                }
                
            }
            else
            {
                Console.WriteLine("Connessione DB fallita\n");
                return false;
            }

            
        }


        public bool LoginUser(string email, string passw)
        {
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
            {   //Cerco sul DB se credenziali corrette
                string Login_string = "SELECT * FROM UTENTE Where Email = '" + email + "' AND Passw = '" + passw +"'";
                MySqlCommand cmd = new MySqlCommand(Login_string, conn);

                if (cmd.ExecuteReader().HasRows) {
                    conn.Close();
                    conn.Dispose();
                    return true;
                }
                else {
                    conn.Close();
                    conn.Dispose();
                    return false;
                }
                    
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                return false;
            }
        }

        public List<Film> FilmsList()
        {
            conn.Open();

            List<Film> films = new List<Film>();

            try
            {  
                string query = "SELECT * FROM FILM";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1));
                    Film film = new Film(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToBoolean(reader.GetString(3)), reader.GetString(4));
                    films.Add(film);
                }
                conn.Close();
                conn.Dispose();
                return films;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                conn.Dispose();
                return films;
            }
        }

        public bool RentFilm(int user_id, int film_id, string start_nol, string stop_nol) {

            conn.Open();

            try
            {
                string cmd_string = "INSERT INTO NOLEGGIO (IdUtente, IdFilm, InizioNoleggio, FineNoleggio) VALUES ('" + user_id + "', '" + film_id + "', '" + start_nol + "', '" + stop_nol + "')";
                Console.WriteLine(cmd_string);
                MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                return false;
            }
        }

        public bool SetFilmStatus(int film_id, bool disp) {
            conn.Open();

            try
            {
                string cmd_string = "UPDATE FILM SET Disponibile = " + Convert.ToInt32(disp) + " WHERE FILM.Id = " + film_id + ";";
                Console.WriteLine(cmd_string);
                MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                return false;
            }
        }
    }
}
