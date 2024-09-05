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
        private string ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from CRBook where bk_return_date is null", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DateTime dueDate = Convert.ToDateTime(row.Cells[5].Value);

                    if (DateTime.Today > dueDate)
                    {
                        row.DefaultCellStyle.ForeColor = Color.Red; // Highlight overdue books
                    }
                }

                cmd.CommandText = "Select * from CRBook where bk_return_date is not null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                dataGridView2.DataSource = ds1.Tables[0];
            }
        }
    }
}
