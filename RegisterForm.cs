using cineteca.ServiceReference;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cineteca
{
    public partial class RegisterForm : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();       //creo istanza del client

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
            if (tb_register_password.Text.Equals(tb_register_repeat_password.Text))
            {
                int root = 0;                                       //Variabile per essere Utente ROOT
                if (tb_register_admin_code.Text == "root")          //Controllo codice
                    root = 1;

                //Chiamata al servizio per registrazione Utente
                if (wcfClient.RegisterUser(tb_register_email.Text, tb_register_password.Text, tb_register_name.Text, tb_register_surname.Text, root))
                {
                    l_operation_status.Text = "User admin added";

                    Utente myUtente = wcfClient.GetUser(tb_register_email.Text);        //Oggetto utente con credenziali

                    Form homeForm = new Home(myUtente);                                 //Creiamo HomeForm e passaimo oggetto utente    
                    this.Hide();                                                        //nascondo RegForm
                    homeForm.ShowDialog();
                    this.Close();                                                       //Chiudo il nascosto RegForm

                }
                else
                {
                    l_operation_status.Text = "Email Already Exist";
                }
            }
            else
            {
                l_operation_status.Text = "Password don't match";
            }  
        }
    }
}
