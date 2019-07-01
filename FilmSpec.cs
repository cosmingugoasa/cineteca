using System.Drawing;
using System.Windows.Forms;

namespace cineteca
{
    public partial class FilmSpec : Form
    {
        public FilmSpec(Image myImg, string myTitolo, string myDesc, bool myDisp)
        {
            InitializeComponent();
            img_film.Image = myImg;
            l_titolo.Text = myTitolo;
            l_descrizione.Text = myDesc;

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

        }
    }
}
