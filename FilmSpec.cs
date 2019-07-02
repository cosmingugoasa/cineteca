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

        public FilmSpec(Utente myUtente, Image myImg, int myId, string myTitolo, string myDesc, bool myDisp)
        {
            InitializeComponent();
            img_film.Image = myImg;
            film_id = myId;
            l_titolo.Text = myTitolo;
            l_descrizione.Text = myDesc;
            utenteAttuale = myUtente;

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

        private void btn_noleggia_Click(object sender, System.EventArgs e)
        {
            DateTime date1 = new DateTime(2019, 07, 01);
            DateTime date2 = new DateTime(2019, 08, 01);
            if (wcfClient.RentFilm(utenteAttuale.id, film_id, date1.ToString("yyyy-MM-dd"), date2.ToString("yyyy-MM-dd")) && wcfClient.SetFilmStatus(film_id, false))
            {
                MessageBox.Show("Film Noleggiato !");
                Close();
            }
            else
            {
                MessageBox.Show("Errore !");
                Close();
            }
        }
    }
}
