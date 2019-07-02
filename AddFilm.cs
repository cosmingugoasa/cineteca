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
    public partial class AddFilm : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();
        public AddFilm()
        {
            InitializeComponent();
        }

        private void LabelDisponibile_Click(object sender, EventArgs e)
        {

        }

        private void btn_InsertFilm(object sender, EventArgs e)
        {
            try
            {
                if(wcfClient.InsertFilm(tb_titolo.Text, tb_descrizone.Text, cb_disponibile.Checked, tb_urlCopertina.Text))
                {
                    System.Windows.Forms.MessageBox.Show("FILM INSERITO CORRETTAMENTE");
                    tb_titolo.Clear();
                    tb_descrizone.Clear();
                    cb_disponibile.Checked = false;
                    tb_urlCopertina.Clear();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("ERRORE PARAMETRI NON CORRETTI, RIPROVA");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }
    }
}
