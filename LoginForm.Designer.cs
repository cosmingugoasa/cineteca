namespace cineteca
{
    partial class LoginForm
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
            this.l_status = new System.Windows.Forms.Label();
            this.btn_status = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OperationStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_email_login
            // 
            this.tb_email_login.Location = new System.Drawing.Point(153, 21);
            this.tb_email_login.Name = "tb_email_login";
            this.tb_email_login.Size = new System.Drawing.Size(210, 20);
            this.tb_email_login.TabIndex = 0;
            this.tb_email_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_password_login
            // 
            this.tb_password_login.Location = new System.Drawing.Point(153, 61);
            this.tb_password_login.Name = "tb_password_login";
            this.tb_password_login.Size = new System.Drawing.Size(210, 20);
            this.tb_password_login.TabIndex = 1;
            this.tb_password_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password_login.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(199, 110);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(103, 38);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
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
            // l_status
            // 
            this.l_status.AutoSize = true;
            this.l_status.Location = new System.Drawing.Point(414, 189);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(44, 13);
            this.l_status.TabIndex = 5;
            this.l_status.Text = "status : ";
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.White;
            this.btn_status.Location = new System.Drawing.Point(453, 189);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(15, 15);
            this.btn_status.TabIndex = 6;
            this.btn_status.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // OperationStatus
            // 
            this.OperationStatus.AutoSize = true;
            this.OperationStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.OperationStatus.Location = new System.Drawing.Point(194, 161);
            this.OperationStatus.Name = "OperationStatus";
            this.OperationStatus.Size = new System.Drawing.Size(0, 13);
            this.OperationStatus.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.OperationStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.btn_register_redirect);
            this.Controls.Add(this.l_form_status);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password_login);
            this.Controls.Add(this.tb_email_login);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_email_login;
        private System.Windows.Forms.TextBox tb_password_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label l_form_status;
        private System.Windows.Forms.Button btn_register_redirect;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OperationStatus;
    }
}

