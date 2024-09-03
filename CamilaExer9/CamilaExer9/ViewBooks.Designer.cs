namespace CamilaExer9
{
    partial class ViewBooks
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtVbBook = new System.Windows.Forms.TextBox();
            this.btnVbRefresh = new System.Windows.Forms.Button();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bISBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet1 = new CamilaExer9.LibraryManagementDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVbQuantity = new System.Windows.Forms.TextBox();
            this.txtVbAuthor = new System.Windows.Forms.TextBox();
            this.txtVbTitle = new System.Windows.Forms.TextBox();
            this.txtVbISBN = new System.Windows.Forms.TextBox();
            this.btnVbCancel = new System.Windows.Forms.Button();
            this.btnVbDelete = new System.Windows.Forms.Button();
            this.btnVbUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newBookTableAdapter = new CamilaExer9.LibraryManagementDataSet1TableAdapters.NewBookTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 101);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamilaExer9.Properties.Resources.book__1_;
            this.pictureBox1.Location = new System.Drawing.Point(226, 3);
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
            this.label1.Location = new System.Drawing.Point(335, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(166, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title of the Book:";
            // 
            // txtVbBook
            // 
            this.txtVbBook.Location = new System.Drawing.Point(357, 157);
            this.txtVbBook.Name = "txtVbBook";
            this.txtVbBook.Size = new System.Drawing.Size(206, 22);
            this.txtVbBook.TabIndex = 2;
            this.txtVbBook.TextChanged += new System.EventHandler(this.txtVbBook_TextChanged);
            // 
            // btnVbRefresh
            // 
            this.btnVbRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVbRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVbRefresh.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVbRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnVbRefresh.Location = new System.Drawing.Point(586, 152);
            this.btnVbRefresh.Name = "btnVbRefresh";
            this.btnVbRefresh.Size = new System.Drawing.Size(98, 36);
            this.btnVbRefresh.TabIndex = 4;
            this.btnVbRefresh.Text = "Refresh";
            this.btnVbRefresh.UseVisualStyleBackColor = false;
            this.btnVbRefresh.Click += new System.EventHandler(this.btnVbRefresh_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeColumns = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.bTitleDataGridViewTextBoxColumn,
            this.bAuthorDataGridViewTextBoxColumn,
            this.bISBNDataGridViewTextBoxColumn,
            this.bQuantityDataGridViewTextBoxColumn});
            this.dataGridViewBooks.DataSource = this.newBookBindingSource;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 207);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(799, 244);
            this.dataGridViewBooks.TabIndex = 5;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // bidDataGridViewTextBoxColumn
            // 
            this.bidDataGridViewTextBoxColumn.DataPropertyName = "bid";
            this.bidDataGridViewTextBoxColumn.HeaderText = "bid";
            this.bidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bidDataGridViewTextBoxColumn.Name = "bidDataGridViewTextBoxColumn";
            this.bidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bidDataGridViewTextBoxColumn.Visible = false;
            // 
            // bTitleDataGridViewTextBoxColumn
            // 
            this.bTitleDataGridViewTextBoxColumn.DataPropertyName = "bTitle";
            this.bTitleDataGridViewTextBoxColumn.HeaderText = "Book Title";
            this.bTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bTitleDataGridViewTextBoxColumn.Name = "bTitleDataGridViewTextBoxColumn";
            // 
            // bAuthorDataGridViewTextBoxColumn
            // 
            this.bAuthorDataGridViewTextBoxColumn.DataPropertyName = "bAuthor";
            this.bAuthorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.bAuthorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bAuthorDataGridViewTextBoxColumn.Name = "bAuthorDataGridViewTextBoxColumn";
            // 
            // bISBNDataGridViewTextBoxColumn
            // 
            this.bISBNDataGridViewTextBoxColumn.DataPropertyName = "bISBN";
            this.bISBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.bISBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bISBNDataGridViewTextBoxColumn.Name = "bISBNDataGridViewTextBoxColumn";
            // 
            // bQuantityDataGridViewTextBoxColumn
            // 
            this.bQuantityDataGridViewTextBoxColumn.DataPropertyName = "bQuantity";
            this.bQuantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.bQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bQuantityDataGridViewTextBoxColumn.Name = "bQuantityDataGridViewTextBoxColumn";
            // 
            // newBookBindingSource
            // 
            this.newBookBindingSource.DataMember = "NewBook";
            this.newBookBindingSource.DataSource = this.libraryManagementDataSet1;
            // 
            // libraryManagementDataSet1
            // 
            this.libraryManagementDataSet1.DataSetName = "LibraryManagementDataSet1";
            this.libraryManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.txtVbQuantity);
            this.panel2.Controls.Add(this.txtVbAuthor);
            this.panel2.Controls.Add(this.txtVbTitle);
            this.panel2.Controls.Add(this.txtVbISBN);
            this.panel2.Controls.Add(this.btnVbCancel);
            this.panel2.Controls.Add(this.btnVbDelete);
            this.panel2.Controls.Add(this.btnVbUpdate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 178);
            this.panel2.TabIndex = 6;
            // 
            // txtVbQuantity
            // 
            this.txtVbQuantity.Location = new System.Drawing.Point(519, 73);
            this.txtVbQuantity.Name = "txtVbQuantity";
            this.txtVbQuantity.Size = new System.Drawing.Size(167, 22);
            this.txtVbQuantity.TabIndex = 14;
            // 
            // txtVbAuthor
            // 
            this.txtVbAuthor.Location = new System.Drawing.Point(204, 72);
            this.txtVbAuthor.Name = "txtVbAuthor";
            this.txtVbAuthor.Size = new System.Drawing.Size(167, 22);
            this.txtVbAuthor.TabIndex = 13;
            // 
            // txtVbTitle
            // 
            this.txtVbTitle.Location = new System.Drawing.Point(204, 31);
            this.txtVbTitle.Name = "txtVbTitle";
            this.txtVbTitle.Size = new System.Drawing.Size(167, 22);
            this.txtVbTitle.TabIndex = 12;
            // 
            // txtVbISBN
            // 
            this.txtVbISBN.Location = new System.Drawing.Point(519, 26);
            this.txtVbISBN.Name = "txtVbISBN";
            this.txtVbISBN.ReadOnly = true;
            this.txtVbISBN.Size = new System.Drawing.Size(167, 22);
            this.txtVbISBN.TabIndex = 11;
            // 
            // btnVbCancel
            // 
            this.btnVbCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVbCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVbCancel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnVbCancel.Location = new System.Drawing.Point(597, 121);
            this.btnVbCancel.Name = "btnVbCancel";
            this.btnVbCancel.Size = new System.Drawing.Size(89, 36);
            this.btnVbCancel.TabIndex = 10;
            this.btnVbCancel.Text = "Cancel";
            this.btnVbCancel.UseVisualStyleBackColor = false;
            this.btnVbCancel.Click += new System.EventHandler(this.btnVbCancel_Click);
            // 
            // btnVbDelete
            // 
            this.btnVbDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVbDelete.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVbDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnVbDelete.Location = new System.Drawing.Point(502, 121);
            this.btnVbDelete.Name = "btnVbDelete";
            this.btnVbDelete.Size = new System.Drawing.Size(89, 36);
            this.btnVbDelete.TabIndex = 9;
            this.btnVbDelete.Text = "Delete";
            this.btnVbDelete.UseVisualStyleBackColor = false;
            this.btnVbDelete.Click += new System.EventHandler(this.btnVbDelete_Click);
            // 
            // btnVbUpdate
            // 
            this.btnVbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVbUpdate.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVbUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnVbUpdate.Location = new System.Drawing.Point(407, 121);
            this.btnVbUpdate.Name = "btnVbUpdate";
            this.btnVbUpdate.Size = new System.Drawing.Size(89, 36);
            this.btnVbUpdate.TabIndex = 8;
            this.btnVbUpdate.Text = "Update";
            this.btnVbUpdate.UseVisualStyleBackColor = false;
            this.btnVbUpdate.Click += new System.EventHandler(this.btnVbUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label6.Location = new System.Drawing.Point(416, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(416, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(121, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(121, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title:";
            // 
            // newBookTableAdapter
            // 
            this.newBookTableAdapter.ClearBeforeFill = true;
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(174)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(842, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.btnVbRefresh);
            this.Controls.Add(this.txtVbBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooks";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVbBook;
        private System.Windows.Forms.Button btnVbRefresh;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtVbQuantity;
        private System.Windows.Forms.TextBox txtVbAuthor;
        private System.Windows.Forms.TextBox txtVbTitle;
        private System.Windows.Forms.TextBox txtVbISBN;
        private System.Windows.Forms.Button btnVbCancel;
        private System.Windows.Forms.Button btnVbDelete;
        private System.Windows.Forms.Button btnVbUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private LibraryManagementDataSet1 libraryManagementDataSet1;
        private System.Windows.Forms.BindingSource newBookBindingSource;
        private LibraryManagementDataSet1TableAdapters.NewBookTableAdapter newBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bISBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}