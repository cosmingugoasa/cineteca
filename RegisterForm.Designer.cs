namespace cineteca
{
    partial class RegisterForm
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
            this.SuspendLayout();
            // 
            // l_name
            // 
            this.l_name.AutoSize = true;
            this.l_name.Location = new System.Drawing.Point(26, 15);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(35, 13);
            this.l_name.TabIndex = 0;
            this.l_name.Text = "Name";
            // 
            // tb_register_name
            // 
            this.tb_register_name.Location = new System.Drawing.Point(67, 12);
            this.tb_register_name.Name = "tb_register_name";
            this.tb_register_name.Size = new System.Drawing.Size(100, 20);
            this.tb_register_name.TabIndex = 1;
            // 
            // tb_register_surname
            // 
            this.tb_register_surname.AccessibleName = "l_surname";
            this.tb_register_surname.Location = new System.Drawing.Point(247, 12);
            this.tb_register_surname.Name = "tb_register_surname";
            this.tb_register_surname.Size = new System.Drawing.Size(100, 20);
            this.tb_register_surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AccessibleName = "l_surname";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(372, 15);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(36, 13);
            this.l_email.TabIndex = 4;
            this.l_email.Text = "E-Mail";
            // 
            // tb_register_email
            // 
            this.tb_register_email.Location = new System.Drawing.Point(423, 12);
            this.tb_register_email.Name = "tb_register_email";
            this.tb_register_email.Size = new System.Drawing.Size(173, 20);
            this.tb_register_email.TabIndex = 5;
            // 
            // tb_register_admin_code
            // 
            this.tb_register_admin_code.Location = new System.Drawing.Point(423, 51);
            this.tb_register_admin_code.Name = "tb_register_admin_code";
            this.tb_register_admin_code.Size = new System.Drawing.Size(173, 20);
            this.tb_register_admin_code.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Admin \r\nCode**";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_register_repeat_password
            // 
            this.tb_register_repeat_password.AccessibleName = "l_surname";
            this.tb_register_repeat_password.Location = new System.Drawing.Point(247, 51);
            this.tb_register_repeat_password.Name = "tb_register_repeat_password";
            this.tb_register_repeat_password.Size = new System.Drawing.Size(100, 20);
            this.tb_register_repeat_password.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AccessibleName = "l_surname";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ripeti \r\nPassword";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb_register_password
            // 
            this.tb_register_password.Location = new System.Drawing.Point(67, 51);
            this.tb_register_password.Name = "tb_register_password";
            this.tb_register_password.Size = new System.Drawing.Size(100, 20);
            this.tb_register_password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(247, 113);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 211);
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
            this.Text = "RegisterForm";
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
    }
}