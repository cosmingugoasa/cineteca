namespace cineteca
{
    partial class AddFilm
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
            this.tb_titolo = new System.Windows.Forms.TextBox();
            this.tb_urlCopertina = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.LabelUrl = new System.Windows.Forms.Label();
            this.LabelDisponibile = new System.Windows.Forms.Label();
            this.labelDescrizione = new System.Windows.Forms.Label();
            this.tb_descrizone = new System.Windows.Forms.TextBox();
            this.LabelTitolo = new System.Windows.Forms.Label();
            this.cb_disponibile = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_titolo
            // 
            this.tb_titolo.Location = new System.Drawing.Point(150, 22);
            this.tb_titolo.Name = "tb_titolo";
            this.tb_titolo.Size = new System.Drawing.Size(308, 20);
            this.tb_titolo.TabIndex = 0;
            // 
            // tb_urlCopertina
            // 
            this.tb_urlCopertina.Location = new System.Drawing.Point(150, 61);
            this.tb_urlCopertina.Name = "tb_urlCopertina";
            this.tb_urlCopertina.Size = new System.Drawing.Size(308, 20);
            this.tb_urlCopertina.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(181, 228);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 44);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD FILM";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_InsertFilm);
            // 
            // LabelUrl
            // 
            this.LabelUrl.AutoSize = true;
            this.LabelUrl.Location = new System.Drawing.Point(29, 68);
            this.LabelUrl.Name = "LabelUrl";
            this.LabelUrl.Size = new System.Drawing.Size(77, 13);
            this.LabelUrl.TabIndex = 6;
            this.LabelUrl.Text = "URL Copertina";
            // 
            // LabelDisponibile
            // 
            this.LabelDisponibile.AutoSize = true;
            this.LabelDisponibile.Location = new System.Drawing.Point(29, 182);
            this.LabelDisponibile.Name = "LabelDisponibile";
            this.LabelDisponibile.Size = new System.Drawing.Size(63, 13);
            this.LabelDisponibile.TabIndex = 7;
            this.LabelDisponibile.Text = "Disponibilità";
            // 
            // labelDescrizione
            // 
            this.labelDescrizione.AutoSize = true;
            this.labelDescrizione.Location = new System.Drawing.Point(30, 122);
            this.labelDescrizione.Name = "labelDescrizione";
            this.labelDescrizione.Size = new System.Drawing.Size(62, 13);
            this.labelDescrizione.TabIndex = 8;
            this.labelDescrizione.Text = "Descrizione";
            // 
            // tb_descrizone
            // 
            this.tb_descrizone.Location = new System.Drawing.Point(150, 104);
            this.tb_descrizone.Multiline = true;
            this.tb_descrizone.Name = "tb_descrizone";
            this.tb_descrizone.Size = new System.Drawing.Size(308, 59);
            this.tb_descrizone.TabIndex = 2;
            // 
            // LabelTitolo
            // 
            this.LabelTitolo.AutoSize = true;
            this.LabelTitolo.Location = new System.Drawing.Point(29, 29);
            this.LabelTitolo.Name = "LabelTitolo";
            this.LabelTitolo.Size = new System.Drawing.Size(33, 13);
            this.LabelTitolo.TabIndex = 9;
            this.LabelTitolo.Text = "Titolo";
            // 
            // cb_disponibile
            // 
            this.cb_disponibile.AutoSize = true;
            this.cb_disponibile.Location = new System.Drawing.Point(150, 182);
            this.cb_disponibile.Name = "cb_disponibile";
            this.cb_disponibile.Size = new System.Drawing.Size(96, 17);
            this.cb_disponibile.TabIndex = 10;
            this.cb_disponibile.Text = "(Sbarrare se si)";
            this.cb_disponibile.UseVisualStyleBackColor = true;
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 284);
            this.Controls.Add(this.cb_disponibile);
            this.Controls.Add(this.LabelTitolo);
            this.Controls.Add(this.labelDescrizione);
            this.Controls.Add(this.LabelDisponibile);
            this.Controls.Add(this.LabelUrl);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_descrizone);
            this.Controls.Add(this.tb_urlCopertina);
            this.Controls.Add(this.tb_titolo);
            this.Name = "AddFilm";
            this.Text = "AddFilm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_titolo;
        private System.Windows.Forms.TextBox tb_urlCopertina;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label LabelUrl;
        private System.Windows.Forms.Label LabelDisponibile;
        private System.Windows.Forms.Label labelDescrizione;
        private System.Windows.Forms.TextBox tb_descrizone;
        private System.Windows.Forms.Label LabelTitolo;
        private System.Windows.Forms.CheckBox cb_disponibile;
    }
}