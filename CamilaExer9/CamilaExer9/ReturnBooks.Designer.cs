namespace CamilaExer9
{
    partial class ReturnBooks
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtRbSearch = new System.Windows.Forms.Button();
            this.txtRbMemId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptmemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkcheckoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkreturndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bk_is_overdue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cRBookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet4 = new CamilaExer9.LibraryManagementDataSet4();
            this.cRBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new CamilaExer9.LibraryManagementDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRbDueDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRbCancel = new System.Windows.Forms.Button();
            this.btnRbReturn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRbCheckOutDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.libraryManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cRBookTableAdapter = new CamilaExer9.LibraryManagementDataSetTableAdapters.CRBookTableAdapter();
            this.cRBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet3 = new CamilaExer9.LibraryManagementDataSet3();
            this.cRBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cRBookTableAdapter1 = new CamilaExer9.LibraryManagementDataSet3TableAdapters.CRBookTableAdapter();
            this.cRBookTableAdapter2 = new CamilaExer9.LibraryManagementDataSet4TableAdapters.CRBookTableAdapter();
            this.libraryManagementDataSet6 = new CamilaExer9.LibraryManagementDataSet6();
            this.cRBookBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.cRBookTableAdapter3 = new CamilaExer9.LibraryManagementDataSet6TableAdapters.CRBookTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 101);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamilaExer9.Properties.Resources.return__1_;
            this.pictureBox1.Location = new System.Drawing.Point(230, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(339, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 55);
            this.label5.TabIndex = 1;
            this.label5.Text = "Return Book";
            // 
            // txtRbSearch
            // 
            this.txtRbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.txtRbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtRbSearch.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.txtRbSearch.Location = new System.Drawing.Point(555, 119);
            this.txtRbSearch.Name = "txtRbSearch";
            this.txtRbSearch.Size = new System.Drawing.Size(89, 36);
            this.txtRbSearch.TabIndex = 3;
            this.txtRbSearch.Text = "Search";
            this.txtRbSearch.UseVisualStyleBackColor = false;
            this.txtRbSearch.Click += new System.EventHandler(this.txtRbSearch_Click);
            // 
            // txtRbMemId
            // 
            this.txtRbMemId.Location = new System.Drawing.Point(374, 126);
            this.txtRbMemId.Name = "txtRbMemId";
            this.txtRbMemId.Size = new System.Drawing.Size(167, 22);
            this.txtRbMemId.TabIndex = 3;
            this.txtRbMemId.TextChanged += new System.EventHandler(this.txtRbMemId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(147, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Membership ID:";
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ptnameDataGridViewTextBoxColumn,
            this.ptmemIdDataGridViewTextBoxColumn,
            this.bktitleDataGridViewTextBoxColumn,
            this.bkcheckoutdateDataGridViewTextBoxColumn,
            this.due_date,
            this.bkreturndateDataGridViewTextBoxColumn,
            this.bk_is_overdue});
            this.dataGridViewBooks.DataSource = this.cRBookBindingSource4;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 158);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(772, 214);
            this.dataGridViewBooks.TabIndex = 1;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ptnameDataGridViewTextBoxColumn
            // 
            this.ptnameDataGridViewTextBoxColumn.DataPropertyName = "pt_name";
            this.ptnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.ptnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptnameDataGridViewTextBoxColumn.Name = "ptnameDataGridViewTextBoxColumn";
            // 
            // ptmemIdDataGridViewTextBoxColumn
            // 
            this.ptmemIdDataGridViewTextBoxColumn.DataPropertyName = "pt_memId";
            this.ptmemIdDataGridViewTextBoxColumn.HeaderText = "Membership ID";
            this.ptmemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ptmemIdDataGridViewTextBoxColumn.Name = "ptmemIdDataGridViewTextBoxColumn";
            this.ptmemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bktitleDataGridViewTextBoxColumn
            // 
            this.bktitleDataGridViewTextBoxColumn.DataPropertyName = "bk_title";
            this.bktitleDataGridViewTextBoxColumn.HeaderText = "Book Title";
            this.bktitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bktitleDataGridViewTextBoxColumn.Name = "bktitleDataGridViewTextBoxColumn";
            // 
            // bkcheckoutdateDataGridViewTextBoxColumn
            // 
            this.bkcheckoutdateDataGridViewTextBoxColumn.DataPropertyName = "bk_checkout_date";
            this.bkcheckoutdateDataGridViewTextBoxColumn.HeaderText = "Checkout Date";
            this.bkcheckoutdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bkcheckoutdateDataGridViewTextBoxColumn.Name = "bkcheckoutdateDataGridViewTextBoxColumn";
            // 
            // due_date
            // 
            this.due_date.DataPropertyName = "due_date";
            this.due_date.HeaderText = "Due Date";
            this.due_date.MinimumWidth = 6;
            this.due_date.Name = "due_date";
            // 
            // bkreturndateDataGridViewTextBoxColumn
            // 
            this.bkreturndateDataGridViewTextBoxColumn.DataPropertyName = "bk_return_date";
            this.bkreturndateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.bkreturndateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bkreturndateDataGridViewTextBoxColumn.Name = "bkreturndateDataGridViewTextBoxColumn";
            // 
            // bk_is_overdue
            // 
            this.bk_is_overdue.DataPropertyName = "bk_is_overdue";
            this.bk_is_overdue.HeaderText = "Overdue";
            this.bk_is_overdue.MinimumWidth = 6;
            this.bk_is_overdue.Name = "bk_is_overdue";
            // 
            // cRBookBindingSource3
            // 
            this.cRBookBindingSource3.DataMember = "CRBook";
            this.cRBookBindingSource3.DataSource = this.libraryManagementDataSet4;
            // 
            // libraryManagementDataSet4
            // 
            this.libraryManagementDataSet4.DataSetName = "LibraryManagementDataSet4";
            this.libraryManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRBookBindingSource
            // 
            this.cRBookBindingSource.DataMember = "CRBook";
            this.cRBookBindingSource.DataSource = this.libraryManagementDataSetBindingSource;
            // 
            // libraryManagementDataSetBindingSource
            // 
            this.libraryManagementDataSetBindingSource.DataSource = this.libraryManagementDataSet;
            this.libraryManagementDataSetBindingSource.Position = 0;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.txtRbDueDate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnRbCancel);
            this.panel2.Controls.Add(this.btnRbReturn);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtRbCheckOutDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtRbTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(257, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 219);
            this.panel2.TabIndex = 2;
            // 
            // txtRbDueDate
            // 
            this.txtRbDueDate.Location = new System.Drawing.Point(239, 99);
            this.txtRbDueDate.Name = "txtRbDueDate";
            this.txtRbDueDate.Size = new System.Drawing.Size(255, 22);
            this.txtRbDueDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "Book Due Date:";
            // 
            // btnRbCancel
            // 
            this.btnRbCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnRbCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRbCancel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRbCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnRbCancel.Location = new System.Drawing.Point(405, 180);
            this.btnRbCancel.Name = "btnRbCancel";
            this.btnRbCancel.Size = new System.Drawing.Size(89, 36);
            this.btnRbCancel.TabIndex = 7;
            this.btnRbCancel.Text = "Cancel";
            this.btnRbCancel.UseVisualStyleBackColor = false;
            this.btnRbCancel.Click += new System.EventHandler(this.btnRbCancel_Click);
            // 
            // btnRbReturn
            // 
            this.btnRbReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnRbReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRbReturn.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRbReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnRbReturn.Location = new System.Drawing.Point(310, 180);
            this.btnRbReturn.Name = "btnRbReturn";
            this.btnRbReturn.Size = new System.Drawing.Size(89, 36);
            this.btnRbReturn.TabIndex = 6;
            this.btnRbReturn.Text = "Return";
            this.btnRbReturn.UseVisualStyleBackColor = false;
            this.btnRbReturn.Click += new System.EventHandler(this.btnRbReturn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Book Return Date:";
            // 
            // txtRbCheckOutDate
            // 
            this.txtRbCheckOutDate.Location = new System.Drawing.Point(239, 60);
            this.txtRbCheckOutDate.Name = "txtRbCheckOutDate";
            this.txtRbCheckOutDate.Size = new System.Drawing.Size(255, 22);
            this.txtRbCheckOutDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Checkout Date:";
            // 
            // txtRbTitle
            // 
            this.txtRbTitle.Location = new System.Drawing.Point(239, 22);
            this.txtRbTitle.Name = "txtRbTitle";
            this.txtRbTitle.Size = new System.Drawing.Size(255, 22);
            this.txtRbTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Title:";
            // 
            // libraryManagementDataSetBindingSource1
            // 
            this.libraryManagementDataSetBindingSource1.DataSource = this.libraryManagementDataSet;
            this.libraryManagementDataSetBindingSource1.Position = 0;
            // 
            // cRBookTableAdapter
            // 
            this.cRBookTableAdapter.ClearBeforeFill = true;
            // 
            // cRBookBindingSource1
            // 
            this.cRBookBindingSource1.DataMember = "CRBook";
            this.cRBookBindingSource1.DataSource = this.libraryManagementDataSetBindingSource;
            // 
            // libraryManagementDataSet3
            // 
            this.libraryManagementDataSet3.DataSetName = "LibraryManagementDataSet3";
            this.libraryManagementDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRBookBindingSource2
            // 
            this.cRBookBindingSource2.DataMember = "CRBook";
            this.cRBookBindingSource2.DataSource = this.libraryManagementDataSet3;
            // 
            // cRBookTableAdapter1
            // 
            this.cRBookTableAdapter1.ClearBeforeFill = true;
            // 
            // cRBookTableAdapter2
            // 
            this.cRBookTableAdapter2.ClearBeforeFill = true;
            // 
            // libraryManagementDataSet6
            // 
            this.libraryManagementDataSet6.DataSetName = "LibraryManagementDataSet6";
            this.libraryManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRBookBindingSource4
            // 
            this.cRBookBindingSource4.DataMember = "CRBook";
            this.cRBookBindingSource4.DataSource = this.libraryManagementDataSet6;
            // 
            // cRBookTableAdapter3
            // 
            this.cRBookTableAdapter3.ClearBeforeFill = true;
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(174)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.txtRbSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtRbMemId);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBooks";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button txtRbSearch;
        private System.Windows.Forms.TextBox txtRbMemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRbReturn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRbCheckOutDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRbCancel;
        private System.Windows.Forms.BindingSource libraryManagementDataSetBindingSource1;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource libraryManagementDataSetBindingSource;
        private System.Windows.Forms.BindingSource cRBookBindingSource;
        private LibraryManagementDataSetTableAdapters.CRBookTableAdapter cRBookTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource cRBookBindingSource1;
        private LibraryManagementDataSet3 libraryManagementDataSet3;
        private System.Windows.Forms.BindingSource cRBookBindingSource2;
        private LibraryManagementDataSet3TableAdapters.CRBookTableAdapter cRBookTableAdapter1;
        private LibraryManagementDataSet4 libraryManagementDataSet4;
        private System.Windows.Forms.BindingSource cRBookBindingSource3;
        private LibraryManagementDataSet4TableAdapters.CRBookTableAdapter cRBookTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptmemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkcheckoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkreturndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bk_is_overdue;
        private System.Windows.Forms.TextBox txtRbDueDate;
        private System.Windows.Forms.Label label6;
        private LibraryManagementDataSet6 libraryManagementDataSet6;
        private System.Windows.Forms.BindingSource cRBookBindingSource4;
        private LibraryManagementDataSet6TableAdapters.CRBookTableAdapter cRBookTableAdapter3;
    }
}