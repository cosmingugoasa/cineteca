using cineteca.ServiceReference;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace cineteca
{
    public partial class Home : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();
        Utente utenteAttuale;                                       //usato per mantere le info sull'utente dopo il login

        public Home(Utente myUtente)
        {          
            InitializeComponent();
            utenteAttuale = myUtente;                //inizializziamo Utente
            btn_profile.Text = myUtente.email;       //Email Visibile nel menu'

            if (utenteAttuale.isAdmin)      //Se utente admin, permetto che veda funzionalita' in piu' 
            {
                btn_manage.Visible = true;
            }

            LoadStore();    //Carico film presenti nel negozio
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            LoadStore();
        }

        //creo button tanti quanti sono i film, aggiungo event controller per gestire i click, creo stream di dati in ram per le immagini
        void LoadStore()
        {
            try
            {
                main_panel.Controls.Clear();        //Ripuliamo Home dai film
                List<Film> films = wcfClient.StoreFilmsList().ToList();         //carico lista con film trovati
                if (films.Count() != 0)
                {
                    foreach (Film film in films)
                    {
                        //creo bottone + handler
                        Button btn = new Button();
                        btn.Name = "btn_" + film.id;
                        btn.Size = new Size(150, 200);
                        btn.Margin = new Padding(15, 15, 15, 15);
                        btn.Click += new EventHandler(filmButton_Store_click);
                        //creo stream dati per l'immagine di copertina, mantenute in RAM
                        try
                        {
                            WebClient wc = new WebClient();                         //creaiamo client per effettuare richieste http
                            byte[] bytes = wc.DownloadData(film.url_image);         //download immagine tramite URL drive
                            MemoryStream ms = new MemoryStream(bytes);              //mette i byte nella ram
                            Image img = Image.FromStream(ms);                       //Ricrea immagine tramite i byte
                            btn.Image = img;                                        
                            ms.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            btn.Text = film.titolo;
                        }

                        //assegno oggetto film al bottone
                        btn.Tag = film;
                        if (film.disponibile == false)
                            btn.Enabled = false;
                        main_panel.Controls.Add(btn);
                    }

                    btn_store.Enabled = false;
                    btn_library.Enabled = true;
                }
                else
                    MessageBox.Show("Nessun film disponible");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Nessun film disponible, prova il refresh");
            }
        }

        /*
         * funzione creata da sviluppatori, gestore eventi bottoni Film
         * crea Form FilmSpec in base al bottone del film che viene premuto
         */

        private void filmButton_Store_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form filmSpec = new FilmSpec(utenteAttuale, btn.Image, Convert.ToInt32(((Film)btn.Tag).id), ((Film)btn.Tag).titolo, ((Film)btn.Tag).descrizione, ((Film)btn.Tag).disponibile);
            filmSpec.ShowDialog();
            this.LoadStore();
        }

        private void btn_library_Click_1(object sender, EventArgs e)
        {
            LoadLibrary();      //carica solo i film che l'utente ha noleggiato
            btn_store.Enabled = true;
            btn_library.Enabled = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();      //Riavviamo l'applicazione 
        }

        //pulisce il pannello dei film e fa il refresh per vedere se ci sono aggiornamenti dal DB
        private void btn_refresh_Click(object sender, EventArgs e)      
        {
            if (btn_store.Enabled == false)
            {
                main_panel.Controls.Clear();
                LoadStore();
            }
            else if (btn_library.Enabled == false) {
                main_panel.Controls.Clear();
                LoadLibrary();
            }            
        }
        
        private void LoadLibrary() {
            try
            {
                main_panel.Controls.Clear();        //Ripuliamo Home dai film
                List<Film> films = wcfClient.LibraryFilmsList(utenteAttuale.id).ToList();
                if (films.Count() != 0)
                {
                    foreach (Film film in films)
                    {
                        //creo bottone + handler
                        Button btn = new Button();
                        btn.Name = "btn_" + film.id;
                        btn.Size = new Size(150, 200);
                        btn.Margin = new Padding(15, 15, 15, 15);
                        btn.Click += new EventHandler(filmButton_Library_click);
                        //creo stream dati per l'immagine di copertina
                        try
                        {
                            WebClient wc = new WebClient();                     //creaiamo client per effettuare richieste http
                            byte[] bytes = wc.DownloadData(film.url_image);     //download immagine tramite URL drive
                            MemoryStream ms = new MemoryStream(bytes);          //mette i byte nella ram
                            Image img = Image.FromStream(ms);                   //Ricrea immagine tramite i byte
                            btn.Image = img;                                    //mettiamo  immagine sul bottone
                            ms.Close();
                        }
                        catch
                        {
                            btn.Text = film.titolo;
                        }

                        //assegno oggetto film al bottone
                        btn.Tag = film;
                        main_panel.Controls.Add(btn);

                        btn_store.Enabled = true;
                        btn_library.Enabled = false;
                    }
                }
                else {
                    MessageBox.Show("Non hai noleggiato nessun film.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Nessun film disponibile, prova il refresh.");
            }
        }

        //handler per i bottoni presenti nella libreria dell'utente
        private void filmButton_Library_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form filmSpec = new FilmSpec(utenteAttuale, btn.Image, Convert.ToInt32(((Film)btn.Tag).id), ((Film)btn.Tag).titolo, ((Film)btn.Tag).descrizione);
            filmSpec.ShowDialog();
            this.LoadLibrary();
        }


        private void addFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form addFilm = new AddFilm();       //Creiamo "addFilm" form

            addFilm.ShowDialog();               //Apro Form per aggiungere film
            this.Enabled = true;                //Chiudo tutto altrimenti rimane nascosto e non si chiude il programma
            btn_refresh_Click(this, e);         //Richiamo funzione per fare refresh
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            this.Enabled = false;//disabilito home
            Form removeFilm = new RemoveFilm();//Creiamo "RemoveFilm" form
            removeFilm.ShowDialog();
            this.Enabled = true;//abilito home
            btn_refresh_Click(this, e); //Richiamo funzione per fare refresh
        }
    }
}
 