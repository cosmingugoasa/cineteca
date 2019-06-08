namespace cineteca
{
    partial class Cineteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_email_login = new System.Windows.Forms.TextBox();
            this.tb_password_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.l_form_status = new System.Windows.Forms.Label();
            this.btn_register_redirect = new System.Windows.Forms.Button();
            this.tb_name_register = new System.Windows.Forms.TextBox();
            this.tb_surname_register = new System.Windows.Forms.TextBox();
            this.tb_email_register = new System.Windows.Forms.TextBox();
            this.tb_password_register = new System.Windows.Forms.TextBox();
            this.tb_repeat_password_register = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login_redirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_email_login
            // 
            this.tb_email_login.Location = new System.Drawing.Point(120, 29);
            this.tb_email_login.Name = "tb_email_login";
            this.tb_email_login.Size = new System.Drawing.Size(248, 20);
            this.tb_email_login.TabIndex = 0;
            this.tb_email_login.Text = "email ";
            this.tb_email_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_password_login
            // 
            this.tb_password_login.Location = new System.Drawing.Point(120, 68);
            this.tb_password_login.Name = "tb_password_login";
            this.tb_password_login.Size = new System.Drawing.Size(248, 20);
            this.tb_password_login.TabIndex = 1;
            this.tb_password_login.Text = "password ";
            this.tb_password_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password_login.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(188, 123);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 38);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // l_form_status
            // 
            this.l_form_status.AutoSize = true;
            this.l_form_status.Location = new System.Drawing.Point(154, 190);
            this.l_form_status.Name = "l_form_status";
            this.l_form_status.Size = new System.Drawing.Size(108, 13);
            this.l_form_status.TabIndex = 3;
            this.l_form_status.Text = "Not registered ? Click";
            // 
            // btn_register_redirect
            // 
            this.btn_register_redirect.Location = new System.Drawing.Point(268, 185);
            this.btn_register_redirect.Name = "btn_register_redirect";
            this.btn_register_redirect.Size = new System.Drawing.Size(75, 23);
            this.btn_register_redirect.TabIndex = 4;
            this.btn_register_redirect.Text = "register";
            this.btn_register_redirect.UseVisualStyleBackColor = true;
            this.btn_register_redirect.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // tb_name_register
            // 
            this.tb_name_register.Location = new System.Drawing.Point(116, 53);
            this.tb_name_register.Name = "tb_name_register";
            this.tb_name_register.Size = new System.Drawing.Size(115, 20);
            this.tb_name_register.TabIndex = 5;
            this.tb_name_register.Text = "name";
            this.tb_name_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_surname_register
            // 
            this.tb_surname_register.Location = new System.Drawing.Point(253, 53);
            this.tb_surname_register.Name = "tb_surname_register";
            this.tb_surname_register.Size = new System.Drawing.Size(115, 20);
            this.tb_surname_register.TabIndex = 6;
            this.tb_surname_register.Text = "surname";
            this.tb_surname_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_email_register
            // 
            this.tb_email_register.Location = new System.Drawing.Point(116, 92);
            this.tb_email_register.Name = "tb_email_register";
            this.tb_email_register.Size = new System.Drawing.Size(115, 20);
            this.tb_email_register.TabIndex = 7;
            this.tb_email_register.Text = "email";
            this.tb_email_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_password_register
            // 
            this.tb_password_register.Location = new System.Drawing.Point(253, 92);
            this.tb_password_register.Name = "tb_password_register";
            this.tb_password_register.Size = new System.Drawing.Size(115, 20);
            this.tb_password_register.TabIndex = 8;
            this.tb_password_register.Text = "password";
            this.tb_password_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password_register.UseSystemPasswordChar = true;
            // 
            // tb_repeat_password_register
            // 
            this.tb_repeat_password_register.Location = new System.Drawing.Point(116, 135);
            this.tb_repeat_password_register.Name = "tb_repeat_password_register";
            this.tb_repeat_password_register.Size = new System.Drawing.Size(115, 20);
            this.tb_repeat_password_register.TabIndex = 9;
            this.tb_repeat_password_register.Text = "password";
            this.tb_repeat_password_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_repeat_password_register.UseSystemPasswordChar = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(253, 128);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(136, 33);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_login_redirect
            // 
            this.btn_login_redirect.Location = new System.Drawing.Point(268, 185);
            this.btn_login_redirect.Name = "btn_login_redirect";
            this.btn_login_redirect.Size = new System.Drawing.Size(75, 23);
            this.btn_login_redirect.TabIndex = 11;
            this.btn_login_redirect.Text = "login";
            this.btn_login_redirect.UseVisualStyleBackColor = true;
            this.btn_login_redirect.Click += new System.EventHandler(this.btn_login_redirect_Click);
            // 
            // Cineteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(489, 232);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login_redirect);
            this.Controls.Add(this.tb_repeat_password_register);
            this.Controls.Add(this.tb_password_register);
            this.Controls.Add(this.tb_email_register);
            this.Controls.Add(this.tb_surname_register);
            this.Controls.Add(this.tb_name_register);
            this.Controls.Add(this.btn_register_redirect);
            this.Controls.Add(this.l_form_status);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password_login);
            this.Controls.Add(this.tb_email_login);
            this.Name = "Cineteca";
            this.Text = "Cineteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email_login;
        private System.Windows.Forms.TextBox tb_password_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label l_form_status;
        private System.Windows.Forms.Button btn_register_redirect;
        private System.Windows.Forms.TextBox tb_name_register;
        private System.Windows.Forms.TextBox tb_surname_register;
        private System.Windows.Forms.TextBox tb_email_register;
        private System.Windows.Forms.TextBox tb_password_register;
        private System.Windows.Forms.TextBox tb_repeat_password_register;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login_redirect;
    }
}

