namespace CamilaExer9
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Moccasin;
            this.menuStrip2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.patronToolStripMenuItem,
            this.checkoutToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.bookDetailsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.booksToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.bi6z_elxg_150218;
            this.booksToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNToolStripMenuItem
            // 
            this.addNToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.addNToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.book;
            this.addNToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addNToolStripMenuItem.Name = "addNToolStripMenuItem";
            this.addNToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.addNToolStripMenuItem.Text = "Add New Book";
            this.addNToolStripMenuItem.Click += new System.EventHandler(this.addNToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.viewBookToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.book__1_;
            this.viewBookToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.viewBookToolStripMenuItem.Text = "View Book";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // patronToolStripMenuItem
            // 
            this.patronToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.viewPatronToolStripMenuItem});
            this.patronToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.patronToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.user;
            this.patronToolStripMenuItem.Name = "patronToolStripMenuItem";
            this.patronToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.patronToolStripMenuItem.Text = "Patron";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.addNewToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.user__1_;
            this.addNewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.addNewToolStripMenuItem.Text = "Add Patron";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // viewPatronToolStripMenuItem
            // 
            this.viewPatronToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.viewPatronToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.people;
            this.viewPatronToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.viewPatronToolStripMenuItem.Name = "viewPatronToolStripMenuItem";
            this.viewPatronToolStripMenuItem.Size = new System.Drawing.Size(223, 36);
            this.viewPatronToolStripMenuItem.Text = "View Patron";
            this.viewPatronToolStripMenuItem.Click += new System.EventHandler(this.viewPatronToolStripMenuItem_Click);
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.checkoutToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources._return;
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(142, 36);
            this.checkoutToolStripMenuItem.Text = "Checkout ";
            this.checkoutToolStripMenuItem.Click += new System.EventHandler(this.checkoutToolStripMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.returnToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.return__1_;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.bookDetailsToolStripMenuItem.Image = global::CamilaExer9.Properties.Resources.contact;
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Size = new System.Drawing.Size(171, 36);
            this.bookDetailsToolStripMenuItem.Text = "Book Details";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamilaExer9.Properties.Resources.Library_Management__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

