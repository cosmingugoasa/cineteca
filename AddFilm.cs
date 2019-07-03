using cineteca.ServiceReference;
using System;
using System.Windows.Forms;

namespace cineteca
{
    public partial class AddFilm : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();

        public AddFilm()
        {
            InitializeComponent();
        }

        private void btn_InsertFilm(object sender, EventArgs e)
        {
            try
            {
                if(wcfClient.InsertFilm(tb_titolo.Text, tb_descrizone.Text, cb_disponibile.Checked, tb_urlCopertina.Text))          //inserisce film nel DB
                {
                    MessageBox.Show("Film inserito !");
                    tb_titolo.Clear();
                    tb_descrizone.Clear();
                    cb_disponibile.Checked = false;
                    tb_urlCopertina.Clear();
                }
                else
                {
                    MessageBox.Show("Errore. Parametri non corretti.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
