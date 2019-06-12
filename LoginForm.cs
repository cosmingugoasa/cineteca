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
    public partial class LoginForm : Form
    {
        Form regForm = new RegisterForm();      //riferimento al form di registrazione         

        public LoginForm()
        {
            InitializeComponent();
            regForm.Hide();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            regForm.Show();     //switch tra form di login e form di register
            this.Hide();        //nascondo un form e visualizza l'altro
        }       
    }
}
