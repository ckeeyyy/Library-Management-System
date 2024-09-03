using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamilaExer9
{
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet8.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter3.Fill(this.libraryManagementDataSet8.CRBook);
            // TODO: This line of code loads data into the 'libraryManagementDataSet7.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter2.Fill(this.libraryManagementDataSet7.CRBook);
            // TODO: This line of code loads data into the 'libraryManagementDataSet5.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter1.Fill(this.libraryManagementDataSet5.CRBook);
            // TODO: This line of code loads data into the 'libraryManagementDataSet.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter.Fill(this.libraryManagementDataSet.CRBook);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from CRBook where bk_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            cmd.CommandText = "Select * from CRBook where bk_return_date is not null";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
        }
    }
}
