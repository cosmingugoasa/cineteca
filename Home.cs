using cineteca.ServiceReference;
using System;
using System.Drawing;
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

        void LoadStore()
        {
            foreach (Film film in wcfClient.FilmsList())
            {
                Button btn = new Button();
                btn.Name = "btn_" + film.titolo;
                btn.Text = film.titolo;
                btn.Size = new Size(200, 100);
                btn.Margin = new Padding(15, 15, 15, 15);
                store_panel.Controls.Add(btn);
            }
        }

    }
}
