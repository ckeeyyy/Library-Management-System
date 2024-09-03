namespace CamilaExer9
{
    partial class ViewPatrons
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnVpRefresh = new System.Windows.Forms.Button();
            this.dataGridViewPatrons = new System.Windows.Forms.DataGridView();
            this.bidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPatronBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet2 = new CamilaExer9.LibraryManagementDataSet2();
            this.txtVpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVpMemId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVpUpdate = new System.Windows.Forms.Button();
            this.btnVpDelete = new System.Windows.Forms.Button();
            this.btnVpCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newPatronTableAdapter = new CamilaExer9.LibraryManagementDataSet2TableAdapters.NewPatronTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPatronBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(349, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Patron";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(214, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(292, 133);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(206, 22);
            this.txtPName.TabIndex = 2;
            this.txtPName.TextChanged += new System.EventHandler(this.txtPName_TextChanged);
            // 
            // btnVpRefresh
            // 
            this.btnVpRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVpRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVpRefresh.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVpRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.btnVpRefresh.Location = new System.Drawing.Point(520, 126);
            this.btnVpRefresh.Name = "btnVpRefresh";
            this.btnVpRefresh.Size = new System.Drawing.Size(98, 36);
            this.btnVpRefresh.TabIndex = 3;
            this.btnVpRefresh.Text = "Refresh";
            this.btnVpRefresh.UseVisualStyleBackColor = false;
            this.btnVpRefresh.Click += new System.EventHandler(this.btnVpRefresh_Click);
            // 
            // dataGridViewPatrons
            // 
            this.dataGridViewPatrons.AllowUserToAddRows = false;
            this.dataGridViewPatrons.AllowUserToDeleteRows = false;
            this.dataGridViewPatrons.AllowUserToResizeColumns = false;
            this.dataGridViewPatrons.AllowUserToResizeRows = false;
            this.dataGridViewPatrons.AutoGenerateColumns = false;
            this.dataGridViewPatrons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatrons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatrons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bidDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.pMemIDDataGridViewTextBoxColumn});
            this.dataGridViewPatrons.DataSource = this.newPatronBindingSource;
            this.dataGridViewPatrons.Location = new System.Drawing.Point(367, 173);
            this.dataGridViewPatrons.Name = "dataGridViewPatrons";
            this.dataGridViewPatrons.RowHeadersWidth = 51;
            this.dataGridViewPatrons.RowTemplate.Height = 24;
            this.dataGridViewPatrons.Size = new System.Drawing.Size(421, 252);
            this.dataGridViewPatrons.TabIndex = 4;
            this.dataGridViewPatrons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatrons_CellClick);
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
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "pName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // pMemIDDataGridViewTextBoxColumn
            // 
            this.pMemIDDataGridViewTextBoxColumn.DataPropertyName = "pMemID";
            this.pMemIDDataGridViewTextBoxColumn.HeaderText = "Membership ID";
            this.pMemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pMemIDDataGridViewTextBoxColumn.Name = "pMemIDDataGridViewTextBoxColumn";
            // 
            // newPatronBindingSource
            // 
            this.newPatronBindingSource.DataMember = "NewPatron";
            this.newPatronBindingSource.DataSource = this.libraryManagementDataSet2;
            // 
            // libraryManagementDataSet2
            // 
            this.libraryManagementDataSet2.DataSetName = "LibraryManagementDataSet2";
            this.libraryManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtVpName
            // 
            this.txtVpName.Location = new System.Drawing.Point(191, 49);
            this.txtVpName.Name = "txtVpName";
            this.txtVpName.Size = new System.Drawing.Size(152, 22);
            this.txtVpName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // txtVpMemId
            // 
            this.txtVpMemId.Location = new System.Drawing.Point(191, 87);
            this.txtVpMemId.Name = "txtVpMemId";
            this.txtVpMemId.Size = new System.Drawing.Size(152, 22);
            this.txtVpMemId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.label4.Location = new System.Drawing.Point(3, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Membership ID:";
            // 
            // btnVpUpdate
            // 
            this.btnVpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVpUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVpUpdate.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVpUpdate.Location = new System.Drawing.Point(64, 166);
            this.btnVpUpdate.Name = "btnVpUpdate";
            this.btnVpUpdate.Size = new System.Drawing.Size(89, 36);
            this.btnVpUpdate.TabIndex = 9;
            this.btnVpUpdate.Text = "Update";
            this.btnVpUpdate.UseVisualStyleBackColor = false;
            this.btnVpUpdate.Click += new System.EventHandler(this.btnVpUpdate_Click);
            // 
            // btnVpDelete
            // 
            this.btnVpDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVpDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVpDelete.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVpDelete.Location = new System.Drawing.Point(159, 166);
            this.btnVpDelete.Name = "btnVpDelete";
            this.btnVpDelete.Size = new System.Drawing.Size(89, 36);
            this.btnVpDelete.TabIndex = 10;
            this.btnVpDelete.Text = "Delete";
            this.btnVpDelete.UseVisualStyleBackColor = false;
            this.btnVpDelete.Click += new System.EventHandler(this.btnVpDelete_Click);
            // 
            // btnVpCancel
            // 
            this.btnVpCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(186)))), ((int)(((byte)(207)))));
            this.btnVpCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVpCancel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVpCancel.Location = new System.Drawing.Point(254, 166);
            this.btnVpCancel.Name = "btnVpCancel";
            this.btnVpCancel.Size = new System.Drawing.Size(89, 36);
            this.btnVpCancel.TabIndex = 11;
            this.btnVpCancel.Text = "Cancel";
            this.btnVpCancel.UseVisualStyleBackColor = false;
            this.btnVpCancel.Click += new System.EventHandler(this.btnVpCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.btnVpCancel);
            this.panel2.Controls.Add(this.txtVpName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtVpMemId);
            this.panel2.Controls.Add(this.btnVpDelete);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnVpUpdate);
            this.panel2.Location = new System.Drawing.Point(12, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 252);
            this.panel2.TabIndex = 12;
            // 
            // newPatronTableAdapter
            // 
            this.newPatronTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamilaExer9.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(240, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ViewPatrons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(174)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPatrons);
            this.Controls.Add(this.btnVpRefresh);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ViewPatrons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatrons";
            this.Load += new System.EventHandler(this.ViewPatrons_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatrons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPatronBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Button btnVpRefresh;
        private System.Windows.Forms.DataGridView dataGridViewPatrons;
        private System.Windows.Forms.TextBox txtVpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVpMemId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVpUpdate;
        private System.Windows.Forms.Button btnVpDelete;
        private System.Windows.Forms.Button btnVpCancel;
        private System.Windows.Forms.Panel panel2;
        private LibraryManagementDataSet2 libraryManagementDataSet2;
        private System.Windows.Forms.BindingSource newPatronBindingSource;
        private LibraryManagementDataSet2TableAdapters.NewPatronTableAdapter newPatronTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}