namespace cineteca
{
    partial class FilmSpec
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
            this.l_titolo = new System.Windows.Forms.Label();
            this.l_descrizione = new System.Windows.Forms.Label();
            this.btn_noleggia = new System.Windows.Forms.Button();
            this.img_film = new System.Windows.Forms.PictureBox();
            this.btn_legenda_1 = new System.Windows.Forms.Button();
            this.l_legenda_1 = new System.Windows.Forms.Label();
            this.l_legenda_2 = new System.Windows.Forms.Label();
            this.btn_legenda_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_film)).BeginInit();
            this.SuspendLayout();
            // 
            // l_titolo
            // 
            this.l_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_titolo.Location = new System.Drawing.Point(229, 12);
            this.l_titolo.Name = "l_titolo";
            this.l_titolo.Size = new System.Drawing.Size(232, 27);
            this.l_titolo.TabIndex = 1;
            this.l_titolo.Text = "Titolo Film";
            this.l_titolo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_descrizione
            // 
            this.l_descrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_descrizione.Location = new System.Drawing.Point(229, 52);
            this.l_descrizione.Name = "l_descrizione";
            this.l_descrizione.Size = new System.Drawing.Size(232, 201);
            this.l_descrizione.TabIndex = 2;
            this.l_descrizione.Text = "Descrizione del film Descrizione del film Descrizione del film Descrizione del fi" +
    "lm Descrizione del film Descrizione del film";
            // 
            // btn_noleggia
            // 
            this.btn_noleggia.BackColor = System.Drawing.SystemColors.Control;
            this.btn_noleggia.Location = new System.Drawing.Point(229, 272);
            this.btn_noleggia.Name = "btn_noleggia";
            this.btn_noleggia.Size = new System.Drawing.Size(232, 54);
            this.btn_noleggia.TabIndex = 3;
            this.btn_noleggia.Text = "Noleggia";
            this.btn_noleggia.UseVisualStyleBackColor = false;
            this.btn_noleggia.Click += new System.EventHandler(this.btn_noleggia_Click);
            // 
            // img_film
            // 
            this.img_film.Location = new System.Drawing.Point(12, 12);
            this.img_film.Name = "img_film";
            this.img_film.Size = new System.Drawing.Size(199, 241);
            this.img_film.TabIndex = 0;
            this.img_film.TabStop = false;
            // 
            // btn_legenda_1
            // 
            this.btn_legenda_1.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_legenda_1.Location = new System.Drawing.Point(39, 282);
            this.btn_legenda_1.Name = "btn_legenda_1";
            this.btn_legenda_1.Size = new System.Drawing.Size(15, 15);
            this.btn_legenda_1.TabIndex = 4;
            this.btn_legenda_1.UseVisualStyleBackColor = false;
            // 
            // l_legenda_1
            // 
            this.l_legenda_1.AutoSize = true;
            this.l_legenda_1.Location = new System.Drawing.Point(61, 282);
            this.l_legenda_1.Name = "l_legenda_1";
            this.l_legenda_1.Size = new System.Drawing.Size(62, 13);
            this.l_legenda_1.TabIndex = 5;
            this.l_legenda_1.Text = ": disponibile";
            // 
            // l_legenda_2
            // 
            this.l_legenda_2.AutoSize = true;
            this.l_legenda_2.Location = new System.Drawing.Point(61, 303);
            this.l_legenda_2.Name = "l_legenda_2";
            this.l_legenda_2.Size = new System.Drawing.Size(83, 13);
            this.l_legenda_2.TabIndex = 7;
            this.l_legenda_2.Text = ": non disponibile";
            // 
            // btn_legenda_2
            // 
            this.btn_legenda_2.BackColor = System.Drawing.Color.Firebrick;
            this.btn_legenda_2.Location = new System.Drawing.Point(39, 303);
            this.btn_legenda_2.Name = "btn_legenda_2";
            this.btn_legenda_2.Size = new System.Drawing.Size(15, 15);
            this.btn_legenda_2.TabIndex = 6;
            this.btn_legenda_2.Text = ": non disponibile";
            this.btn_legenda_2.UseVisualStyleBackColor = false;
            // 
            // FilmSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 338);
            this.Controls.Add(this.l_legenda_2);
            this.Controls.Add(this.btn_legenda_2);
            this.Controls.Add(this.l_legenda_1);
            this.Controls.Add(this.btn_legenda_1);
            this.Controls.Add(this.btn_noleggia);
            this.Controls.Add(this.l_descrizione);
            this.Controls.Add(this.l_titolo);
            this.Controls.Add(this.img_film);
            this.Name = "FilmSpec";
            this.Text = "FilmSpec";
            ((System.ComponentModel.ISupportInitialize)(this.img_film)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_film;
        private System.Windows.Forms.Label l_titolo;
        private System.Windows.Forms.Label l_descrizione;
        private System.Windows.Forms.Button btn_noleggia;
        private System.Windows.Forms.Button btn_legenda_1;
        private System.Windows.Forms.Label l_legenda_1;
        private System.Windows.Forms.Label l_legenda_2;
        private System.Windows.Forms.Button btn_legenda_2;
    }
}