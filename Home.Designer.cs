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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_store = new System.Windows.Forms.ToolStripButton();
            this.btn_library = new System.Windows.Forms.ToolStripButton();
            this.btn_profile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_store,
            this.btn_library,
            this.btn_profile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_store
            // 
            this.btn_store.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_store.Image = ((System.Drawing.Image)(resources.GetObject("btn_store.Image")));
            this.btn_store.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(38, 22);
            this.btn_store.Text = "Store";
            // 
            // btn_library
            // 
            this.btn_library.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_library.Image = ((System.Drawing.Image)(resources.GetObject("btn_library.Image")));
            this.btn_library.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_library.Name = "btn_library";
            this.btn_library.Size = new System.Drawing.Size(47, 22);
            this.btn_library.Text = "Library";
            // 
            // btn_profile
            // 
            this.btn_profile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("btn_profile.Image")));
            this.btn_profile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(45, 22);
            this.btn_profile.Text = "Profile";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 618);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_store;
        private System.Windows.Forms.ToolStripButton btn_library;
        private System.Windows.Forms.ToolStripButton btn_profile;
    }
}