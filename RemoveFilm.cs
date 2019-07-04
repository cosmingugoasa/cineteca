using cineteca.ServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cineteca
{
    public partial class RemoveFilm : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();
        public RemoveFilm()
        {
            InitializeComponent();

            try
            {
                List<Film> films = wcfClient.StoreFilmsList().ToList();
                foreach (Film film in films)
                {
                    if (film.disponibile == true) //Se film disponibile lo aggiungo alla lista da eliminare
                        cb_listafilm.Items.Add(film.titolo);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("SERVER NON ATTIVO");
            }
        }

        private void btn_RemoveFilm_Click(object sender, EventArgs e)
        {
            try
            {
                if (wcfClient.RemoveFilm(cb_listafilm.SelectedItem.ToString()))
                {                  
                    MessageBox.Show("FILM ELIMINATO CORRETTAMENTE");
                    cb_listafilm.ResetText();
                    cb_listafilm.Items.Clear();

                    List<Film> films = wcfClient.StoreFilmsList().ToList();
                    foreach (Film film in films)
                    {
                        if (film.disponibile == true)
                            cb_listafilm.Items.Add(film.titolo);
                    }

                }
                else
                    MessageBox.Show("IMPOSSIBILE ELIMNARE FILM");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
