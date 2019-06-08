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
    public partial class Cineteca : Form
    {
        public Cineteca()
        {
            InitializeComponent();
            HideRegisterForm();
        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            HideLoginForm();
            ShowRegisterForm();
        }

        private void btn_login_redirect_Click(object sender, EventArgs e)
        {
            HideRegisterForm();
            ShowLoginForm();
        }

        private void HideRegisterForm() {
            tb_name_register.Hide();
            tb_surname_register.Hide();
            tb_email_register.Hide();
            tb_password_register.Hide();
            tb_repeat_password_register.Hide();
            btn_register.Hide();
            btn_login_redirect.Hide();
        }

        private void ShowRegisterForm() {
            tb_name_register.Show();
            tb_surname_register.Show();
            tb_email_register.Show();
            tb_password_register.Show();
            tb_repeat_password_register.Show();
            btn_register.Show();
            btn_login_redirect.Show();
        }

        private void HideLoginForm() {
            tb_email_login.Hide();
            tb_password_login.Hide();
            btn_login.Hide();
            btn_register_redirect.Hide();

            l_form_status.Text = "Alredy registered ? Click ";
        }

        private void ShowLoginForm() {
            tb_email_login.Show();
            tb_password_login.Show();
            btn_login.Show();
            btn_register_redirect.Show();

            l_form_status.Text = "Not registered ? Click ";
        }
    }
}
