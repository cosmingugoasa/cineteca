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

        public Home(Utente myUtente)
        {          
            InitializeComponent();
            PassEmail.Text = myUtente.email;
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
                btn.Text = film.titolo;
                btn.Size = new Size(200, 100);
                btn.Margin = new Padding(15, 15, 15, 15);
                btn.Click += new EventHandler(filmButton_click);
                //creo stream dati per l'immagine di copertina
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(@"C:\Users\cosmi\Desktop\avatar-dvd-cover-art.jpg"); //da sostituire con url di drive una volta sistemate le immagini(funziona anche ora ma non e' ottimizzato(picchi di memoria occupata))
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                btn.Image = img;
                ms.Close();

                //assegno oggetto film al bottone
                btn.Tag = film;
                store_panel.Controls.Add(btn);
            }
        }

        //funzione creata da sviluppatori
        void filmButton_click(object sender, EventArgs e) {
            Button btn = sender as Button;
            MessageBox.Show(((Film)btn.Tag).descrizione);
        }
    }
}
