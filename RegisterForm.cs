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
    public partial class RegisterForm : Form
    {
        ServerServicesClient wcfClient = new ServiceReference.ServerServicesClient();       //creo istanza del client

        public RegisterForm()
        {
            InitializeComponent();

            try         //controllo connettivita' con il server e aggiorno indicatore status
            {                                                                 
                if (wcfClient.DoWork()) btn_status.BackColor = Color.Lime;
            }
            catch
            {
                btn_status.BackColor = Color.Red;
            }
        }

        private void btn_login_redirect_Click(object sender, EventArgs e)
        {
            (new LoginForm()).Show();             //switch tra form di login e form di register
            this.Hide();                          //nascondo un form e visualizza l'altro
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int root = 0;                                       //Variabile se Utente ROOT
            if (tb_register_admin_code.Text == "root")          //Controllo TextBox
                root = 1;

            //Chiamata al servizio per registrazione Utente
            if (wcfClient.RegisterUser(tb_register_email.Text, tb_register_password.Text, tb_register_name.Text, tb_register_surname.Text, root))
            {
                l_operation_status.Text = "User admin added";
            }
            else
            {
                l_operation_status.Text = "Query failed";
            }

        }
    }
}
