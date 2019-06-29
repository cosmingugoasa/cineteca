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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_store = new System.Windows.Forms.ToolStripButton();
            this.btn_library = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.store_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.PassEmail = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            this.store_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_store,
            this.btn_library,
            this.toolStripDropDownButton2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(777, 39);
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
            this.btn_store.Size = new System.Drawing.Size(38, 19);
            this.btn_store.Text = "Store";
            // 
            // btn_library
            // 
            this.btn_library.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_library.Image = ((System.Drawing.Image)(resources.GetObject("btn_library.Image")));
            this.btn_library.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_library.Margin = new System.Windows.Forms.Padding(10);
            this.btn_library.Name = "btn_library";
            this.btn_library.Size = new System.Drawing.Size(47, 19);
            this.btn_library.Text = "Library";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_logout});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(54, 19);
            this.toolStripDropDownButton2.Text = "Profile";
            // 
            // btn_logout
            // 
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(180, 22);
            this.btn_logout.Text = "Logout";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Gray;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripDropDownButton1.Text = "Profile";
            // 
            // store_panel
            // 
            this.store_panel.Controls.Add(this.button1);
            this.store_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.store_panel.Location = new System.Drawing.Point(0, 39);
            this.store_panel.Name = "store_panel";
            this.store_panel.Size = new System.Drawing.Size(777, 386);
            this.store_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 116);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PassEmail
            // 
            this.PassEmail.AutoSize = true;
            this.PassEmail.Location = new System.Drawing.Point(636, 9);
            this.PassEmail.Name = "PassEmail";
            this.PassEmail.Size = new System.Drawing.Size(0, 13);
            this.PassEmail.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 425);
            this.Controls.Add(this.store_panel);
            this.Controls.Add(this.PassEmail);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.store_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_store;
        private System.Windows.Forms.ToolStripButton btn_library;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem btn_logout;
        private System.Windows.Forms.FlowLayoutPanel store_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PassEmail;
    }
}