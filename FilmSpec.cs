using cineteca.ServiceReference;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cineteca
{
    public partial class FilmSpec : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();
        Utente utenteAttuale;
        int film_id;

        public FilmSpec(Utente myUtente, Image myImg, int myFilmId, string myTitolo, string myDesc, bool myDisp)
        {
            InitializeComponent();
            img_film.Image = myImg;
            film_id = myFilmId;
            l_titolo.Text = myTitolo;
            l_descrizione.Text = myDesc;
            utenteAttuale = myUtente;

            btn_restituisci.Visible = false;
            btn_legenda_1.Enabled = false;
            btn_legenda_2.Enabled = false;

            if (myDisp)
            {
                btn_noleggia.BackColor = Color.LimeGreen;
            }
            else
            {
                btn_noleggia.BackColor = Color.Firebrick;
                btn_noleggia.Enabled = false;
            }
        }

        public FilmSpec(Utente myUtente, Image myImg, int myFilmId, string myTitolo, string myDesc)
        {
            InitializeComponent();
            img_film.Image = myImg;
            film_id = myFilmId;
            l_titolo.Text = myTitolo;
            l_descrizione.Text = myDesc;
            utenteAttuale = myUtente;

            btn_legenda_1.Visible = false;
            btn_legenda_2.Visible = false;
            l_legenda_1.Visible = false;
            l_legenda_2.Visible = false;
            btn_noleggia.Visible = false;

        }

        private void btn_noleggia_Click(object sender, EventArgs e)
        {
            DateTime date1;
            date1 = DateTime.Today;
            DateTime date2;
            date2 = date1.AddMonths(1);

            if (wcfClient.GetFilmDisp(film_id))
            {
                if (wcfClient.RentFilm(utenteAttuale.id, film_id, date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd")) && wcfClient.SetFilmStatus(film_id, false))
                {
                    MessageBox.Show("Film Noleggiato !");
                    Close();
                }
                else
                {
                    MessageBox.Show("Errore nel Noleggiare !");
                    Close();
                }
            }
            else {
                MessageBox.Show("Errore nel Noleggiare !");
                Close();
            }
            
        }

        private void btn_restituisci_Click(object sender, EventArgs e)
        {
            if (wcfClient.ReturnFilm(utenteAttuale.id, film_id) && wcfClient.SetFilmStatus(film_id, true)){
                MessageBox.Show("Film Restituito !");
                Close();
            }
            else {
                MessageBox.Show("Errore nel Restituire !");
                Close();
            }
        }
    }
}
