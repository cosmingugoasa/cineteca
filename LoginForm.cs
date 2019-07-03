using cineteca.ServiceReference;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace cineteca
{
    public partial class LoginForm : Form
    {
        ServerServicesClient wcfClient = new ServerServicesClient();       //creo istanza del client
        Form regForm = new RegisterForm();                                 //riferimento al form di registrazione         

        public LoginForm()
        {
            InitializeComponent();
            regForm.Hide();
            
            try{                                                                 //controllo connettivita' con il server e aggiorno indicatore status
                if (wcfClient.DoWork()) btn_status.BackColor = Color.Lime;
            }
            catch { 
                btn_status.BackColor = Color.Red;
            }
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            regForm.Show();     //switch tra form di login e form di register
            this.Hide();        //nascondo un form e visualizza l'altro
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(tb_email_login.Text))
            {
                if (wcfClient.LoginUser(tb_email_login.Text, tb_password_login.Text))        //controllo se credenziali corrette
                {
                    OperationStatus.Text = "Login completed";

                    Form homeForm = new Home(wcfClient.GetUser(tb_email_login.Text));       //Creiamo HomeForm e passiamo oggetto utente

                    this.Hide();                //nascondo LoginForm
                    homeForm.ShowDialog();      //Apro Home
                    this.Close();               //Chiudo tutto altrimenti rimane nascosto e non si chiude il programma
                }
                else
                {
                    OperationStatus.Text = "Username or Password are incorrect";
                }
            }
            else
            {
                OperationStatus.Text = "Username or Password are incorrect";
            }
        }

        /*
         * controllo se e' una possibile mail dal punto di vista della sintassi, 
         * non se e' una mail valida come destinatario di un messaggio 
         */
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
