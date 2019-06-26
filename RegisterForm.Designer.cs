namespace cineteca
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_name = new System.Windows.Forms.Label();
            this.tb_register_name = new System.Windows.Forms.TextBox();
            this.tb_register_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_email = new System.Windows.Forms.Label();
            this.tb_register_email = new System.Windows.Forms.TextBox();
            this.tb_register_admin_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_register_repeat_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_register_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.l_redirect = new System.Windows.Forms.Label();
            this.btn_login_redirect = new System.Windows.Forms.Button();
            this.btn_status = new System.Windows.Forms.Button();
            this.l_status = new System.Windows.Forms.Label();
            this.l_operation_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(70, 27);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(35, 13);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "Name";
            // 
            // tb_register_name
            // 
            this.tb_register_name.Location = new System.Drawing.Point(111, 24);
            this.tb_register_name.Name = "tb_register_name";
            this.tb_register_name.Size = new System.Drawing.Size(100, 20);
            this.tb_register_name.TabIndex = 1;
            // 
            // tb_register_surname
            // 
            this.tb_register_surname.AccessibleName = "l_surname";
            this.tb_register_surname.Location = new System.Drawing.Point(291, 24);
            this.tb_register_surname.Name = "tb_register_surname";
            this.tb_register_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_register_surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AccessibleName = "l_surname";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(416, 27);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(36, 13);
            this.l_email.TabIndex = 4;
            this.l_email.Text = "E-Mail";
            // 
            // tb_register_email
            // 
            this.tb_register_email.Location = new System.Drawing.Point(467, 24);
            this.tb_register_email.Name = "tb_register_email";
            this.tb_register_email.Size = new System.Drawing.Size(173, 20);
            this.tb_register_email.TabIndex = 5;
            // 
            // tb_register_admin_code
            // 
            this.tb_register_admin_code.Location = new System.Drawing.Point(467, 63);
            this.tb_register_admin_code.Name = "tb_register_admin_code";
            this.tb_register_admin_code.Size = new System.Drawing.Size(173, 20);
            this.tb_register_admin_code.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Admin \r\nCode**";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_register_repeat_password
            // 
            this.tb_register_repeat_password.AccessibleName = "l_surname";
            this.tb_register_repeat_password.Location = new System.Drawing.Point(291, 63);
            this.tb_register_repeat_password.Name = "tb_register_repeat_password";
            this.tb_register_repeat_password.Size = new System.Drawing.Size(100, 20);
            this.tb_register_repeat_password.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AccessibleName = "l_surname";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ripeti \r\nPassword";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_register_password
            // 
            this.tb_register_password.Location = new System.Drawing.Point(111, 63);
            this.tb_register_password.Name = "tb_register_password";
            this.tb_register_password.Size = new System.Drawing.Size(100, 20);
            this.tb_register_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(275, 114);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(137, 35);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // l_redirect
            // 
            this.l_redirect.AutoSize = true;
            this.l_redirect.Location = new System.Drawing.Point(243, 171);
            this.l_redirect.Name = "l_redirect";
            this.l_redirect.Size = new System.Drawing.Size(126, 13);
            this.l_redirect.TabIndex = 13;
            this.l_redirect.Text = "Already registered ? Click";
            // 
            // btn_login_redirect
            // 
            this.btn_login_redirect.Location = new System.Drawing.Point(375, 166);
            this.btn_login_redirect.Name = "btn_login_redirect";
            this.btn_login_redirect.Size = new System.Drawing.Size(75, 23);
            this.btn_login_redirect.TabIndex = 14;
            this.btn_login_redirect.Text = "Login";
            this.btn_login_redirect.UseVisualStyleBackColor = true;
            this.btn_login_redirect.Click += new System.EventHandler(this.btn_login_redirect_Click);
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.White;
            this.btn_status.Location = new System.Drawing.Point(659, 189);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(15, 15);
            this.btn_status.TabIndex = 16;
            this.btn_status.UseVisualStyleBackColor = false;
            // 
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(620, 189);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(44, 13);
            this.l_status.TabIndex = 15;
            this.l_status.Text = "status : ";
            // 
            // l_operation_status
            // 
            this.l_operation_status.AutoSize = true;
            this.l_operation_status.ForeColor = System.Drawing.Color.DarkRed;
            this.l_operation_status.Location = new System.Drawing.Point(288, 192);
            this.l_operation_status.Name = "l_operation_status";
            this.l_operation_status.Size = new System.Drawing.Size(16, 13);
            this.l_operation_status.TabIndex = 17;
            this.l_operation_status.Text = "...";
            this.l_operation_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(686, 211);
            this.Controls.Add(this.l_operation_status);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.btn_login_redirect);
            this.Controls.Add(this.l_redirect);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_register_admin_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_register_repeat_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_register_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_register_email);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.tb_register_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_register_name);
            this.Controls.Add(this.l_name);
            this.Name = "RegisterForm";
            this.Text = "Register LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_name;
        private System.Windows.Forms.TextBox tb_register_name;
        private System.Windows.Forms.TextBox tb_register_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.TextBox tb_register_email;
        private System.Windows.Forms.TextBox tb_register_admin_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_register_repeat_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label l_redirect;
        private System.Windows.Forms.Button btn_login_redirect;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_operation_status;
    }
}