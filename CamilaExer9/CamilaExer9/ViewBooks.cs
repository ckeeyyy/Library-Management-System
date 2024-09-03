using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CamilaExer9
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            // Load data into the NewBook table
            this.newBookTableAdapter.Fill(this.libraryManagementDataSet1.NewBook);
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewBooks.DataSource = ds.Tables[0];
        }

        Int64 isbn;

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                isbn = Int64.Parse(dataGridViewBooks.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook where bISBN=" + isbn + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            txtVbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
            txtVbAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtVbISBN.Text = ds.Tables[0].Rows[0][3].ToString(); // ISBN is already read-only
            txtVbQuantity.Text = ds.Tables[0].Rows[0][4].ToString();
        }

        private void btnVbCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtVbBook_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            if (txtVbBook.Text != "")
            {
                cmd.CommandText = "Select * from NewBook where bTitle LIKE '" + txtVbBook.Text + "%'";
            }
            else
            {
                cmd.CommandText = "Select * from NewBook";
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewBooks.DataSource = ds.Tables[0];
        }

        private void btnVbRefresh_Click(object sender, EventArgs e)
        {
            txtVbBook.Clear();
            panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewBooks.DataSource = ds.Tables[0];
        }

        private void btnVbUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Book Details will be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Retrieve updated values from the text boxes
                String bTitle = txtVbTitle.Text;
                String bAuthor = txtVbAuthor.Text;
                Int64 bQuantity = Int64.Parse(txtVbQuantity.Text);

                // Establish the database connection
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
                {
                    try
                    {
                        con.Open();

                        // Update the NewBook table using ISBN as the key
                        using (SqlCommand cmd = new SqlCommand("UPDATE NewBook SET bTitle = @bTitle, bAuthor = @bAuthor, bQuantity = @bQuantity WHERE bISBN = @isbn", con))
                        {
                            cmd.Parameters.AddWithValue("@bTitle", bTitle);
                            cmd.Parameters.AddWithValue("@bAuthor", bAuthor);
                            cmd.Parameters.AddWithValue("@bQuantity", bQuantity);
                            cmd.Parameters.AddWithValue("@isbn", isbn); // Use ISBN as the key
                            cmd.ExecuteNonQuery();
                        }

                        // Update related records in the CRBook table using ISBN as the key
                        using (SqlCommand cmd = new SqlCommand("UPDATE CRBook SET bk_title = @bTitle WHERE bk_ISBN = @isbn", con))
                        {
                            cmd.Parameters.AddWithValue("@bTitle", bTitle);
                            cmd.Parameters.AddWithValue("@isbn", isbn); // Use ISBN as the key
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Book details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating the book details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnVbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Book will be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewBook where bISBN=" + isbn + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
