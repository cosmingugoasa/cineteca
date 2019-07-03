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
            this.main_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_store = new System.Windows.Forms.ToolStripButton();
            this.btn_library = new System.Windows.Forms.ToolStripButton();
            this.btn_profile = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_refresh = new System.Windows.Forms.ToolStripButton();
            this.btn_manage = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_add_film = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.AutoScroll = true;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 40);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(766, 437);
            this.main_panel.TabIndex = 1;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_store,
            this.btn_library,
            this.btn_profile,
            this.btn_refresh,
            this.btn_manage});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(766, 40);
            this.toolStripMenu.TabIndex = 0;
            this.toolStripMenu.Text = "toolStrip1";
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
            // btn_refresh
            // 
            this.btn_refresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_refresh.Image = global::cineteca.Properties.Resources.refresh;
            this.btn_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(10);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(23, 20);
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_manage
            // 
            this.btn_manage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_manage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_film,
            this.btn_remove});
            this.btn_manage.Image = ((System.Drawing.Image)(resources.GetObject("btn_manage.Image")));
            this.btn_manage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_manage.Margin = new System.Windows.Forms.Padding(10);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(63, 20);
            this.btn_manage.Text = "Manage";
            // 
            // btn_add_film
            // 
            this.btn_add_film.Name = "btn_add_film";
            this.btn_add_film.Size = new System.Drawing.Size(180, 22);
            this.btn_add_film.Text = "Add Film";
            this.btn_add_film.Click += new System.EventHandler(this.addFilmToolStripMenuItem_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(180, 22);
            this.btn_remove.Text = "Remove Film";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 477);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.toolStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel main_panel;

        private System.Windows.Forms.ToolStripButton btn_store;

        private System.Windows.Forms.ToolStripButton btn_library;

        private System.Windows.Forms.ToolStripDropDownButton btn_profile;

        private System.Windows.Forms.ToolStripMenuItem btn_logout;

        private System.Windows.Forms.ToolStrip toolStripMenu;
        
        private System.Windows.Forms.ToolStripButton btn_refresh;
        private System.Windows.Forms.ToolStripDropDownButton btn_manage;
        private System.Windows.Forms.ToolStripMenuItem btn_add_film;
        private System.Windows.Forms.ToolStripMenuItem btn_remove;
    }
}