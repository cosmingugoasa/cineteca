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
        Utente utenteAttuale;
        public Home(Utente myUtente)
        {          
            InitializeComponent();
            utenteAttuale = myUtente;                //inizializziamo Utente
            btn_profile.Text = myUtente.email;       //Email Visibile nella DDL

            if (utenteAttuale.isAdmin) //Se utente admin permetto di aggiungere film
            {
                btn_manage.Visible = true;
            }

            LoadStore();    //Carico film
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
                main_panel.Controls.Clear();   //Ripuliamo Home dai film
                List<Film> films = wcfClient.StoreFilmsList().ToList();
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
                        //creo stream dati per l'immagine di copertina
                        try
                        {
                            WebClient wc = new WebClient(); //creaiamo client per effettuare richieste http
                            byte[] bytes = wc.DownloadData(film.url_image); //download immagine tramite URL drive
                            MemoryStream ms = new MemoryStream(bytes); //mette i byte nella ram
                            Image img = Image.FromStream(ms);//Ricrea immagine tramite i byte
                            btn.Image = img; //mettiamo  immagine sul bottone
                            ms.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                            btn.Text = film.titolo;
                        }

                        //assegno oggetto film al bottone
                        btn.Tag = film;
                        main_panel.Controls.Add(btn);
                    }

                    btn_store.Enabled = false;
                    btn_library.Enabled = true;
                }
                else
                    MessageBox.Show("NESSUN FILM DISPONIBILE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("NESSUN FILM DISPONIBILE AL MOMENTO, PROVA IL REFRESH");
            }
        }

        //funzione creata da sviluppatori, gestore eventi bottoni Film
        private void filmButton_Store_click(object sender, EventArgs e) {
            Button btn = sender as Button;
            Form filmSpec = new FilmSpec(utenteAttuale, btn.Image, Convert.ToInt32(((Film)btn.Tag).id), ((Film)btn.Tag).titolo, ((Film)btn.Tag).descrizione, ((Film)btn.Tag).disponibile);
            filmSpec.ShowDialog();
            this.LoadStore();
        }

        private void btn_library_Click_1(object sender, EventArgs e)
        {
            LoadLibrary();
            btn_store.Enabled = true;
            btn_library.Enabled = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart(); //Riavviamo l'applicazione 
        }

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
                main_panel.Controls.Clear();   //Ripuliamo Home dai film
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
                            WebClient wc = new WebClient(); //creaiamo client per effettuare richieste http
                            byte[] bytes = wc.DownloadData(film.url_image); //download immagine tramite URL drive
                            MemoryStream ms = new MemoryStream(bytes); //mette i byte nella ram
                            Image img = Image.FromStream(ms);//Ricrea immagine tramite i byte
                            btn.Image = img; //mettiamo  immagine sul bottone
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
                    MessageBox.Show("NON HAI NOLEGGIATO NESSUN FILM");
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("NESSUN FILM DISPONIBILE AL MOMENTO, PROVA IL REFRESH");
            }
        }

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
            Form addFilm = new AddFilm();//Creiamo "addFilm" form

            addFilm.ShowDialog();//Apro Home
            this.Enabled = true; //Chiudo tutto altrimenti rimane nascosto e non si chiude il programma
            btn_refresh_Click(this, e); //Richiamo funzione per fare refresh
        }
    }
}
 