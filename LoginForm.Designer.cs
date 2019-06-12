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
            this.SuspendLayout();
            // 
            // tb_email_login
            // 
            this.tb_email_login.Location = new System.Drawing.Point(115, 21);
            this.tb_email_login.Name = "tb_email_login";
            this.tb_email_login.Size = new System.Drawing.Size(248, 20);
            this.tb_email_login.TabIndex = 0;
            this.tb_email_login.Text = "email ";
            this.tb_email_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_password_login
            // 
            this.tb_password_login.Location = new System.Drawing.Point(115, 60);
            this.tb_password_login.Name = "tb_password_login";
            this.tb_password_login.Size = new System.Drawing.Size(248, 20);
            this.tb_password_login.TabIndex = 1;
            this.tb_password_login.Text = "password ";
            this.tb_password_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password_login.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(183, 115);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 38);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // l_form_status
            // 
            this.l_form_status.AutoSize = true;
            this.l_form_status.Location = new System.Drawing.Point(149, 182);
            this.l_form_status.Name = "l_form_status";
            this.l_form_status.Size = new System.Drawing.Size(108, 13);
            this.l_form_status.TabIndex = 3;
            this.l_form_status.Text = "Not registered ? Click";
            // 
            // btn_register_redirect
            // 
            this.btn_register_redirect.Location = new System.Drawing.Point(263, 177);
            this.btn_register_redirect.Name = "btn_register_redirect";
            this.btn_register_redirect.Size = new System.Drawing.Size(75, 23);
            this.btn_register_redirect.TabIndex = 4;
            this.btn_register_redirect.Text = "register";
            this.btn_register_redirect.UseVisualStyleBackColor = true;
            this.btn_register_redirect.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // Cineteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btn_register_redirect);
            this.Controls.Add(this.l_form_status);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password_login);
            this.Controls.Add(this.tb_email_login);
            this.Name = "Cineteca";
            this.Text = "Login Cineteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email_login;
        private System.Windows.Forms.TextBox tb_password_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label l_form_status;
        private System.Windows.Forms.Button btn_register_redirect;
    }
}

