using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace WCFServer
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "ServerServices" nel codice e nel file di configurazione contemporaneamente.
    public class ServerServices : IServerServices
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        
        public bool DoWork()        //usata solo per controllare connettivita' dal client 
        {
            return true;
        }
        
        public Utente GetUser(string email) //Restituise Un oggetto utente contentente i dati dell'utente
        {
            Utente myUtente = new Utente();
            try
            {
                conn.Open();                                                                //apro connessione al DB
                string strQuery = "SELECT * FROM UTENTE where email = '" + email + "'";     //stringa query
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);                        //creo comando
                MySqlDataReader reader = cmd.ExecuteReader();                               //eseguo comando, tramite reader per avere i record tornati

                while (reader.Read())
                {
                    myUtente = new Utente(Convert.ToInt32(reader["Id"]), reader["Email"].ToString(), reader["Passw"].ToString(), reader["Nome"].ToString(), reader["Cognome"].ToString(), Convert.ToBoolean(reader["IsAdmin"]));
                }
                return myUtente;            //creo utente 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return myUtente;
            }
            finally
            {
                conn.Close();
            }
        }
        
        //Registrazione dell'utente su db
        public bool RegisterUser(string email, string passw, string nome, string cognome, int isAdmin) 
        {    
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string cmd_string = "INSERT INTO UTENTE (Email, Passw, Nome, Cognome, IsAdmin) VALUES ('" + email + "', '" + passw + "', '" + nome + "', '" + cognome + "', '" + isAdmin + "')";
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                    if (cmd.ExecuteReader().HasRows)    //controllo se il DB mi ritorna dei record
                    {      
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }
                    else
                    {
                        conn.Close();
                        conn.Dispose();
                        Console.WriteLine("ERRORE REGISTRAZIONE\n");
                        return false;
                    }

                }
                else
                {
                    Console.WriteLine("Connessione DB fallita\n");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                conn.Dispose();
                return false;
            }                
        }
        
        public bool LoginUser(string email, string passw)//Login dell'utente
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    //Cerco sul DB se credenziali corrette
                    string Login_string = "SELECT * FROM UTENTE Where Email = '" + email + "' AND Passw = '" + passw + "'";
                    MySqlCommand cmd = new MySqlCommand(Login_string, conn);

                    if (cmd.ExecuteReader().HasRows)        //controllo se il DB mi ritorna dei record
                    {
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }
                    else
                    {
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                conn.Dispose();
                return false;
            }
        }

        public List<Film> StoreFilmsList()      //Ritorna lista di film dal DB da caricare nella home
        {     
            List<Film> films = new List<Film>();
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string query = "SELECT * FROM FILM";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())                               //creo lista dei film disponibili da mandare al client
                    {
                        Film film = new Film(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2), Convert.ToBoolean(reader.GetString(3)), reader.GetString(4));
                        films.Add(film);
                    }
                    conn.Close();
                    conn.Dispose();
                    return films;
                }
                else
                {
                    Console.WriteLine("Connessione DB fallita\n");
                    return films;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                conn.Dispose();
                return films;
            }
        }

        public bool RentFilm(int user_id, int film_id, string start_nol, string stop_nol)       //Restituire film noleggiato
        { 
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MySqlTransaction transaction = conn.BeginTransaction();         //creo transazione per assicurarmi che tutte le query abbiano successo
                    string cmd_string = "INSERT INTO NOLEGGIO (IdUtente, IdFilm, InizioNoleggio, FineNoleggio) VALUES ('" + user_id + "', '" + film_id + "', '" + start_nol + "', '" + stop_nol + "')";
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn, transaction);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        transaction.Commit();                   //se le query hanno successo, salva le modifiche fatte al db
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                        transaction.Rollback();                 //se le query falliscono annulla tutto
                    }
                    finally {
                        conn.Close();
                    }       
                    return true;
                }
                else
                {
                    Console.WriteLine("Connessione DB fallita\n");
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

        public bool SetFilmStatus(int film_id, bool disp) {         //Si rende indisponibile il film
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string cmd_string = "UPDATE FILM SET Disponibile = " + Convert.ToInt32(disp) + " WHERE FILM.Id = " + film_id + ";";
                    Console.WriteLine(cmd_string);
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                else
                {
                    Console.WriteLine("Connessione DB fallita\n");
                    Console.WriteLine();
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

        public List<Film> LibraryFilmsList(int user_id) {       //creo lista di film presenti nella libreria di un determinato utente

            List<Film> films = new List<Film>();
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string query = "SELECT * FROM NOLEGGIO, FILM WHERE IdFilm = FILM.Id AND IdUtente = " + user_id;
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())       //creo film e lo aggiungo alla lista
                    {
                        Console.WriteLine(reader["IdFilm"] + " " + reader["Titolo"]);
                        Film film = new Film(Convert.ToInt32(reader["IdFilm"]), reader["Titolo"].ToString(), reader["Descrizione"].ToString(), Convert.ToBoolean(reader["Disponibile"]), reader["UrlImage"].ToString());
                        films.Add(film);
                    }
                    conn.Close();
                    conn.Dispose();
                    return films;
                }
                else{
                    Console.WriteLine("Connessione DB fallita\n");
                    return films;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                conn.Dispose();
                return films;
            }
        }

        public bool ReturnFilm(int user_id, int film_id)        //restituisco film al DB e lo rendo disponibile per altri utenti
        {
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string cmd_delete = "DELETE FROM NOLEGGIO WHERE IdUtente = " + user_id + " AND IdFilm = " + film_id;
                    MySqlCommand cmd = new MySqlCommand(cmd_delete, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                else{
                    Console.WriteLine("Connessione DB fallita\n");
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

        public bool InsertFilm(string titolo, string descrizione, bool disponibile, string url_image)  {        //Inserisce film nel DB
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string cmd_string = "INSERT INTO FILM (Titolo, Descrizione, Disponibile, UrlImage) VALUES ('" + titolo + "', '" + descrizione + "', " + disponibile + ", '" + url_image + "')";
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                    
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }
                    else{
                        conn.Close();
                        conn.Dispose();
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Connessione DB fallita\n");
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

        public bool RemoveFilm(string titolo)   //Elimina film nel DB
        { 
            try
                conn.Open();
            {
                {
                if (conn.State == ConnectionState.Open)
                    MySqlTransaction transaction = conn.BeginTransaction();
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn, transaction);
                    string cmd_string = "DELETE FROM FILM WHERE Titolo = '" + titolo +"'" ;
                    try

                    {
                        cmd.ExecuteNonQuery();
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        Console.WriteLine(e.ToString());
                        return false;
                    finally
                    }
                    {
                        conn.Close();

                    }
                else
                }
                    conn.Close();
                    Console.WriteLine("Connessione DB fallita\n");
                {
                    conn.Dispose();
                }
            }
                    return false;

            catch (Exception ex)
                Console.WriteLine(ex.ToString());
            {
                conn.Close();
            }
                return false;
        }

        public bool GetFilmDisp(int film_id) {          //controllo se il film e' disponibile per il noleggio
            bool status = false;
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    string cmd_string = "SELECT * FROM FILM WHERE Id = " + film_id;
                    MySqlCommand cmd = new MySqlCommand(cmd_string, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Disponibile"].ToString() == "True")
                        {
                            status = true;
                        }
                    }
                    conn.Close();
                    return status;
                }
                else
                {
                    return status = false; ;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                conn.Close();
                return status = false; ;
            }
        }
    }
}
