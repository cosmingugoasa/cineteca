using cineteca.ServiceReference;
using System;
using System.Drawing;
using System.IO;
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
            utenteAttuale = myUtente;
            btn_profile.Text = myUtente.email;
            LoadStore();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            LoadStore();
        }

        //creo button tanti quanti sono i film, aggiungo event controller per gestire i click, creo stream di dati in ram per le immagini
        void LoadStore()
        {
            foreach (Film film in wcfClient.FilmsList())
            {
                //creo bottone + handler
                Button btn = new Button();
                btn.Name = "btn_" + film.titolo;
                btn.Size = new Size(150, 200);
                btn.Margin = new Padding(15, 15, 15, 15);
                btn.Click += new EventHandler(filmButton_click);
                //creo stream dati per l'immagine di copertina
                WebClient wc = new WebClient(); //creaiamo client per effettuare richieste http
                byte[] bytes = wc.DownloadData(film.url_image); //download immagine tramite URL drive
                MemoryStream ms = new MemoryStream(bytes); //mette i byte nella ram
                Image img = Image.FromStream(ms);//Ricrea immagine tramite i byte
                btn.Image = img; //mettiamo  immagine sul bottone
                ms.Close();

                //assegno oggetto film al bottone
                btn.Tag = film;
                store_panel.Controls.Add(btn);
            }

            btn_store.Enabled = false;
            btn_library.Enabled = true;
        }

        //funzione creata da sviluppatori, gestore eventi bottoni Film
        void filmButton_click(object sender, EventArgs e) {
            Button btn = sender as Button;

            Form filmSpec = new FilmSpec(btn.Image, ((Film)btn.Tag).titolo, ((Film)btn.Tag).descrizione, ((Film)btn.Tag).disponibile);
            filmSpec.Show();
        }

        private void btn_library_Click_1(object sender, EventArgs e)
        {
            store_panel.Controls.Clear();
            btn_store.Enabled = true;

            btn_library.Enabled = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            store_panel.Controls.Clear();
            LoadStore();
        }
    }
}
