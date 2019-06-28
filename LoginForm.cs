using cineteca.ServiceReference;
using MySql.Data.MySqlClient;
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
        ServerServicesClient wcfClient = new ServiceReference.ServerServicesClient();       //creo istanza del client
        Form regForm = new RegisterForm();                                                  //riferimento al form di registrazione  

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
            if (wcfClient.LoginUser(tb_email_login.Text,tb_password_login.Text))
            {
                OperationStatus.Text = "Login completed";
            }
            else
            {
                OperationStatus.Text = "Username or Password are incorrect";
            }
            
            
        }
    }
}
