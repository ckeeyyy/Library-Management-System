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
    public partial class AddNewBooks : Form
    {
        public AddNewBooks()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtAuthor.Text != "" && txtISBN.Text != "" && txtQuantity.Text != "")
            {

                String bTitle = txtTitle.Text;
                String bAuthor = txtAuthor.Text;
                Int64 bISBN = Convert.ToInt64(txtISBN.Text);
                Int64 bQuantity = Convert.ToInt64(txtQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook(bTitle, bAuthor, bISBN, bQuantity) values ('" + bTitle + "', '" + bAuthor + "'," + bISBN + "," + bQuantity + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Book Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTitle.Clear();
                txtAuthor.Clear();
                txtISBN.Clear();
                txtQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE your Unsaved DATA,","Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
