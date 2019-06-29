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
    public partial class Home : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();

        public Home()
        {
            InitializeComponent();
            List<Film> films = new List<Film>();
            films = wcfClient.FilmsList().ToList();

            foreach (Film film in films){
                   
            }

        }

        

    }
}
