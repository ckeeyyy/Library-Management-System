namespace CamilaExer9
{
    partial class BookDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cRBookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet7 = new CamilaExer9.LibraryManagementDataSet7();
            this.cRBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet5 = new CamilaExer9.LibraryManagementDataSet5();
            this.cRBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new CamilaExer9.LibraryManagementDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cRBookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet8 = new CamilaExer9.LibraryManagementDataSet8();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cRBookTableAdapter = new CamilaExer9.LibraryManagementDataSetTableAdapters.CRBookTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cRBookTableAdapter1 = new CamilaExer9.LibraryManagementDataSet5TableAdapters.CRBookTableAdapter();
            this.cRBookTableAdapter2 = new CamilaExer9.LibraryManagementDataSet7TableAdapters.CRBookTableAdapter();
            this.cRBookTableAdapter3 = new CamilaExer9.LibraryManagementDataSet8TableAdapters.CRBookTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptmemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkcheckoutdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkreturndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptmemIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bktitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkcheckoutdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bkreturndateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bk_is_overdue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet8)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ptnameDataGridViewTextBoxColumn,
            this.ptmemIdDataGridViewTextBoxColumn,
            this.bktitleDataGridViewTextBoxColumn,
            this.bkcheckoutdateDataGridViewTextBoxColumn,
            this.due_date,
            this.bkreturndateDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.cRBookBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // cRBookBindingSource2
            // 
            this.cRBookBindingSource2.DataMember = "CRBook";
            this.cRBookBindingSource2.DataSource = this.libraryManagementDataSet7;
            // 
            // libraryManagementDataSet7
            // 
            this.libraryManagementDataSet7.DataSetName = "LibraryManagementDataSet7";
            this.libraryManagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRBookBindingSource1
            // 
            this.cRBookBindingSource1.DataMember = "CRBook";
            this.cRBookBindingSource1.DataSource = this.libraryManagementDataSet5;
            // 
            // libraryManagementDataSet5
            // 
            this.libraryManagementDataSet5.DataSetName = "LibraryManagementDataSet5";
            this.libraryManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cRBookBindingSource
            // 
            this.cRBookBindingSource.DataMember = "CRBook";
            this.cRBookBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.ptnameDataGridViewTextBoxColumn1,
            this.ptmemIdDataGridViewTextBoxColumn1,
            this.bktitleDataGridViewTextBoxColumn1,
            this.bkcheckoutdateDataGridViewTextBoxColumn1,
            this.bkreturndateDataGridViewTextBoxColumn1,
            this.bk_is_overdue});
            this.dataGridView2.DataSource = this.cRBookBindingSource3;
            this.dataGridView2.Location = new System.Drawing.Point(12, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(776, 177);
            this.dataGridView2.TabIndex = 1;
            // 
            // cRBookBindingSource3
            // 
            this.cRBookBindingSource3.DataMember = "CRBook";
            this.cRBookBindingSource3.DataSource = this.libraryManagementDataSet8;
            // 
            // libraryManagementDataSet8
            // 
            this.libraryManagementDataSet8.DataSetName = "LibraryManagementDataSet8";
            this.libraryManagementDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(325, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Checkedout Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(334, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Returned Books";
            // 
            // cRBookTableAdapter
            // 
            this.cRBookTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 29);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 29);
            this.panel2.TabIndex = 5;
            // 
            // cRBookTableAdapter1
            // 
            this.cRBookTableAdapter1.ClearBeforeFill = true;
            // 
            // cRBookTableAdapter2
            // 
            this.cRBookTableAdapter2.ClearBeforeFill = true;
            // 
            // cRBookTableAdapter3
            // 
            this.cRBookTableAdapter3.ClearBeforeFill = true;
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
            this.due_date.HeaderText = "Return Date";
            this.due_date.MinimumWidth = 6;
            this.due_date.Name = "due_date";
            // 
            // bkreturndateDataGridViewTextBoxColumn
            // 
            this.bkreturndateDataGridViewTextBoxColumn.DataPropertyName = "bk_return_date";
            this.bkreturndateDataGridViewTextBoxColumn.HeaderText = "Actual Return Date";
            this.bkreturndateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bkreturndateDataGridViewTextBoxColumn.Name = "bkreturndateDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "bk_is_overdue";
            this.Column1.HeaderText = "Overdue";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ptnameDataGridViewTextBoxColumn1
            // 
            this.ptnameDataGridViewTextBoxColumn1.DataPropertyName = "pt_name";
            this.ptnameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.ptnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ptnameDataGridViewTextBoxColumn1.Name = "ptnameDataGridViewTextBoxColumn1";
            // 
            // ptmemIdDataGridViewTextBoxColumn1
            // 
            this.ptmemIdDataGridViewTextBoxColumn1.DataPropertyName = "pt_memId";
            this.ptmemIdDataGridViewTextBoxColumn1.HeaderText = "Membership ID";
            this.ptmemIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ptmemIdDataGridViewTextBoxColumn1.Name = "ptmemIdDataGridViewTextBoxColumn1";
            this.ptmemIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bktitleDataGridViewTextBoxColumn1
            // 
            this.bktitleDataGridViewTextBoxColumn1.DataPropertyName = "bk_title";
            this.bktitleDataGridViewTextBoxColumn1.HeaderText = "Book Title";
            this.bktitleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bktitleDataGridViewTextBoxColumn1.Name = "bktitleDataGridViewTextBoxColumn1";
            // 
            // bkcheckoutdateDataGridViewTextBoxColumn1
            // 
            this.bkcheckoutdateDataGridViewTextBoxColumn1.DataPropertyName = "bk_checkout_date";
            this.bkcheckoutdateDataGridViewTextBoxColumn1.HeaderText = "Checkout Date";
            this.bkcheckoutdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bkcheckoutdateDataGridViewTextBoxColumn1.Name = "bkcheckoutdateDataGridViewTextBoxColumn1";
            // 
            // bkreturndateDataGridViewTextBoxColumn1
            // 
            this.bkreturndateDataGridViewTextBoxColumn1.DataPropertyName = "bk_return_date";
            this.bkreturndateDataGridViewTextBoxColumn1.HeaderText = "Actual Return Date";
            this.bkreturndateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bkreturndateDataGridViewTextBoxColumn1.Name = "bkreturndateDataGridViewTextBoxColumn1";
            // 
            // bk_is_overdue
            // 
            this.bk_is_overdue.DataPropertyName = "bk_is_overdue";
            this.bk_is_overdue.HeaderText = "Overdue";
            this.bk_is_overdue.MinimumWidth = 6;
            this.bk_is_overdue.Name = "bk_is_overdue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Overdue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamilaExer9.Properties.Resources.red;
            this.pictureBox1.Location = new System.Drawing.Point(642, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 10);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(174)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookDetails";
            this.Load += new System.EventHandler(this.BookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRBookBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource cRBookBindingSource;
        private LibraryManagementDataSetTableAdapters.CRBookTableAdapter cRBookTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private LibraryManagementDataSet5 libraryManagementDataSet5;
        private System.Windows.Forms.BindingSource cRBookBindingSource1;
        private LibraryManagementDataSet5TableAdapters.CRBookTableAdapter cRBookTableAdapter1;
        private LibraryManagementDataSet7 libraryManagementDataSet7;
        private System.Windows.Forms.BindingSource cRBookBindingSource2;
        private LibraryManagementDataSet7TableAdapters.CRBookTableAdapter cRBookTableAdapter2;
        private LibraryManagementDataSet8 libraryManagementDataSet8;
        private System.Windows.Forms.BindingSource cRBookBindingSource3;
        private LibraryManagementDataSet8TableAdapters.CRBookTableAdapter cRBookTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptmemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkcheckoutdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkreturndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptmemIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bktitleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkcheckoutdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bkreturndateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bk_is_overdue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}