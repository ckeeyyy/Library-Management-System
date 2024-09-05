namespace CamilaExer9
{
    partial class CheckOutBooks
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchPatron = new System.Windows.Forms.Button();
            this.txtCbMemId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCbISBN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBooks = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.libraryManagementDataSet9 = new CamilaExer9.LibraryManagementDataSet9();
            this.newBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newBookTableAdapter = new CamilaExer9.LibraryManagementDataSet9TableAdapters.NewBookTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 101);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamilaExer9.Properties.Resources._return;
            this.pictureBox1.Location = new System.Drawing.Point(222, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(331, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(67)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btnSearchPatron);
            this.panel2.Controls.Add(this.txtCbMemId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 320);
            this.panel2.TabIndex = 1;
            // 
            // btnSearchPatron
            // 
            this.btnSearchPatron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnSearchPatron.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchPatron.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPatron.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnSearchPatron.Location = new System.Drawing.Point(89, 137);
            this.btnSearchPatron.Name = "btnSearchPatron";
            this.btnSearchPatron.Size = new System.Drawing.Size(89, 36);
            this.btnSearchPatron.TabIndex = 1;
            this.btnSearchPatron.Text = "Search Patron";
            this.btnSearchPatron.UseVisualStyleBackColor = false;
            this.btnSearchPatron.Click += new System.EventHandler(this.btnSearchPatron_Click);
            // 
            // txtCbMemId
            // 
            this.txtCbMemId.Location = new System.Drawing.Point(52, 99);
            this.txtCbMemId.Name = "txtCbMemId";
            this.txtCbMemId.Size = new System.Drawing.Size(167, 22);
            this.txtCbMemId.TabIndex = 1;
            this.txtCbMemId.TextChanged += new System.EventHandler(this.txtCbMemId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Membership ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.panel3.Controls.Add(this.txtCbISBN);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBoxBooks);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtMemId);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtCbName);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(295, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 320);
            this.panel3.TabIndex = 2;
            // 
            // txtCbISBN
            // 
            this.txtCbISBN.Location = new System.Drawing.Point(198, 151);
            this.txtCbISBN.Name = "txtCbISBN";
            this.txtCbISBN.ReadOnly = true;
            this.txtCbISBN.Size = new System.Drawing.Size(255, 22);
            this.txtCbISBN.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(38, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "ISBN:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(198, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2024, 9, 1, 20, 28, 19, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(36, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = "Return Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(290, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Checkout Limit: 3 Books";
            // 
            // comboBoxBooks
            // 
            this.comboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBooks.FormattingEnabled = true;
            this.comboBoxBooks.Location = new System.Drawing.Point(198, 110);
            this.comboBoxBooks.Name = "comboBoxBooks";
            this.comboBoxBooks.Size = new System.Drawing.Size(255, 24);
            this.comboBoxBooks.TabIndex = 11;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnCheckOut.Location = new System.Drawing.Point(322, 254);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(131, 36);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label7.Location = new System.Drawing.Point(36, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 27);
            this.label7.TabIndex = 8;
            this.label7.Text = "Checkout Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(36, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Book Title:";
            // 
            // txtMemId
            // 
            this.txtMemId.Location = new System.Drawing.Point(198, 67);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.ReadOnly = true;
            this.txtMemId.Size = new System.Drawing.Size(255, 22);
            this.txtMemId.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(36, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Membership ID:";
            // 
            // txtCbName
            // 
            this.txtCbName.Location = new System.Drawing.Point(198, 25);
            this.txtCbName.Name = "txtCbName";
            this.txtCbName.ReadOnly = true;
            this.txtCbName.Size = new System.Drawing.Size(255, 22);
            this.txtCbName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(36, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // libraryManagementDataSet9
            // 
            this.libraryManagementDataSet9.DataSetName = "LibraryManagementDataSet9";
            this.libraryManagementDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newBookBindingSource
            // 
            this.newBookBindingSource.DataMember = "NewBook";
            this.newBookBindingSource.DataSource = this.libraryManagementDataSet9;
            // 
            // newBookTableAdapter
            // 
            this.newBookTableAdapter.ClearBeforeFill = true;
            // 
            // CheckOutBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(174)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckOutBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOutBooks";
            this.Load += new System.EventHandler(this.CheckOutBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCbMemId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchPatron;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ComboBox comboBoxBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCbISBN;
        private LibraryManagementDataSet9 libraryManagementDataSet9;
        private System.Windows.Forms.BindingSource newBookBindingSource;
        private LibraryManagementDataSet9TableAdapters.NewBookTableAdapter newBookTableAdapter;
    }
}