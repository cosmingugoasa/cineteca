namespace cineteca
{
    partial class RemoveFilm
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
            this.cb_listafilm = new System.Windows.Forms.ComboBox();
            this.lb_cbFilm = new System.Windows.Forms.Label();
            this.btn_RemoveFilm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_listafilm
            // 
            this.cb_listafilm.FormattingEnabled = true;
            this.cb_listafilm.Location = new System.Drawing.Point(146, 43);
            this.cb_listafilm.Name = "cb_listafilm";
            this.cb_listafilm.Size = new System.Drawing.Size(233, 21);
            this.cb_listafilm.TabIndex = 0;
            // 
            // lb_cbFilm
            // 
            this.lb_cbFilm.AutoSize = true;
            this.lb_cbFilm.Location = new System.Drawing.Point(39, 43);
            this.lb_cbFilm.Name = "lb_cbFilm";
            this.lb_cbFilm.Size = new System.Drawing.Size(86, 13);
            this.lb_cbFilm.TabIndex = 1;
            this.lb_cbFilm.Text = "Selezionare Film:";
            // 
            // btn_RemoveFilm
            // 
            this.btn_RemoveFilm.Location = new System.Drawing.Point(134, 112);
            this.btn_RemoveFilm.Name = "btn_RemoveFilm";
            this.btn_RemoveFilm.Size = new System.Drawing.Size(121, 54);
            this.btn_RemoveFilm.TabIndex = 2;
            this.btn_RemoveFilm.Text = "Rimuovi Film";
            this.btn_RemoveFilm.UseVisualStyleBackColor = true;
            this.btn_RemoveFilm.Click += new System.EventHandler(this.btn_RemoveFilm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATTENZIONE: film noleggiati non si possono eliminare";
            // 
            // RemoveFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RemoveFilm);
            this.Controls.Add(this.lb_cbFilm);
            this.Controls.Add(this.cb_listafilm);
            this.Name = "RemoveFilm";
            this.Text = "Remove Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_listafilm;
        private System.Windows.Forms.Label lb_cbFilm;
        private System.Windows.Forms.Button btn_RemoveFilm;
        private System.Windows.Forms.Label label1;
    }
}