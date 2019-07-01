namespace cineteca
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.store_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_store = new System.Windows.Forms.ToolStripButton();
            this.btn_library = new System.Windows.Forms.ToolStripButton();
            this.btn_profile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_addFilm = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // store_panel
            // 
            this.store_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.store_panel.Location = new System.Drawing.Point(0, 40);
            this.store_panel.Name = "store_panel";
            this.store_panel.Size = new System.Drawing.Size(777, 437);
            this.store_panel.TabIndex = 1;
            // 
            // btn_store
            // 
            this.btn_store.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_store.Image = ((System.Drawing.Image)(resources.GetObject("btn_store.Image")));
            this.btn_store.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_store.Margin = new System.Windows.Forms.Padding(10);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(38, 20);
            this.btn_store.Text = "Store";
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // btn_library
            // 
            this.btn_library.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_library.Image = ((System.Drawing.Image)(resources.GetObject("btn_library.Image")));
            this.btn_library.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_library.Margin = new System.Windows.Forms.Padding(10);
            this.btn_library.Name = "btn_library";
            this.btn_library.Size = new System.Drawing.Size(47, 20);
            this.btn_library.Text = "Library";
            this.btn_library.Click += new System.EventHandler(this.btn_library_Click_1);
            // 
            // btn_profile
            // 
            this.btn_profile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_profile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_logout});
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_profile.Margin = new System.Windows.Forms.Padding(10);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(13, 20);
            // 
            // btn_logout
            // 
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(112, 22);
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_store,
            this.btn_library,
            this.btn_profile,
            this.btn_refresh});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(777, 40);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(23, 20);
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_addFilm
            // 
            this.btn_addFilm.Location = new System.Drawing.Point(653, 11);
            this.btn_addFilm.Name = "btn_addFilm";
            this.btn_addFilm.Size = new System.Drawing.Size(75, 23);
            this.btn_addFilm.TabIndex = 2;
            this.btn_addFilm.Text = "Add Film";
            this.btn_addFilm.UseVisualStyleBackColor = true;
            this.btn_addFilm.Visible = false;
            this.btn_addFilm.Click += new System.EventHandler(this.btn_addFilm_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 477);
            this.Controls.Add(this.btn_addFilm);
            this.Controls.Add(this.store_panel);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel store_panel;
        private System.Windows.Forms.ToolStripButton btn_store;
        private System.Windows.Forms.ToolStripButton btn_library;
        private System.Windows.Forms.ToolStripDropDownButton btn_profile;
        private System.Windows.Forms.ToolStripMenuItem btn_logout;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.Button btn_addFilm;
    }
}