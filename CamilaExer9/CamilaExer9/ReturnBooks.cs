using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CamilaExer9
{
    public partial class ReturnBooks : Form
    {
        private string ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'libraryManagementSystemDataSet.CRBook' table. You can move, or remove it, as needed.
            //this.cRBookTableAdapter4.Fill(this.libraryManagementSystemDataSet.CRBook);

            dataGridViewBooks.DataSource = null;
            panel2.Visible = false;
            txtRbMemId.Clear();
           dateTimePicker2.Enabled = false;
        }

        private void txtRbSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from CRBook where pt_memId = @MemId and bk_return_date IS NULL", con);
                cmd.Parameters.AddWithValue("@MemId", txtRbMemId.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridViewBooks.DataSource = ds.Tables[0];

                    // Check if books are overdue
                    foreach (DataGridViewRow row in dataGridViewBooks.Rows)
                    {
                        DateTime dueDate = Convert.ToDateTime(row.Cells["due_date"].Value);
                        if (DateTime.Today > dueDate)
                        {
                            row.DefaultCellStyle.ForeColor = Color.Red; // Highlight overdue books
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Membership ID or No Book Checked out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridViewBooks.DataSource = null; // Clear the DataGridView if no data found
                }
            }
        }

        private string btitle;
        private string bdate;
        private string bdate1;
        private long rowid;

        private void dataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panel2.Visible = true;

                if (dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    rowid = long.Parse(dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                    btitle = dataGridViewBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                    bdate = dataGridViewBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
                    bdate1 = dataGridViewBooks.Rows[e.RowIndex].Cells[5].Value.ToString();

                    DateTime dueDate = Convert.ToDateTime(bdate1);
                    if (DateTime.Today > dueDate)
                    {
                        dateTimePicker2.ForeColor = Color.Red; // Highlight the due date if overdue
                        MessageBox.Show("This book is overdue!", "Overdue Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                txtRbTitle.Text = btitle;
                dateTimePicker3.Value = DateTime.Parse(bdate);
                dateTimePicker2.Value = DateTime.Parse(bdate1);
            }
            catch (Exception ex)
            {
                return;
            }
           
        }

        private void btnRbReturn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString)) // Use separate method for connection string
            {
                try
                {
                    con.Open();

                    DateTime actualReturnDate = dateTimePicker3.Value;
                    //DateTime dueDate = DateTime.Parse(txtRbDueDate.Text);
                    DateTime dueDate = dateTimePicker2.Value ;
                    bool isOverdue = actualReturnDate > dueDate;


                    // Update the bk_actual_return_date, bk_is_overdue, and bk_overdue_days in the CRBook table
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE CRBook " +
                        "SET bk_return_date = @ActualReturnDate, " +
                        "bk_is_overdue = @IsOverdue " + // Adjust data type if needed for your database
                        "WHERE pt_memId = @MemId AND id = " + rowid + "", con);

                    cmd.Parameters.AddWithValue("@ActualReturnDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@IsOverdue", isOverdue); // Assuming boolean data type for bk_is_overdue
                    cmd.Parameters.AddWithValue("@MemId", txtRbMemId.Text);
                    cmd.Parameters.AddWithValue("@RowId", rowid);

                    cmd.ExecuteNonQuery();

                    // Update the quantity of the returned book in the NewBook table
                    SqlCommand updateQuantityCmd = new SqlCommand("UPDATE NewBook SET bQuantity = bQuantity + 1 WHERE bTitle = @BookTitle", con);
                    updateQuantityCmd.Parameters.AddWithValue("@BookTitle", btitle);
                    updateQuantityCmd.ExecuteNonQuery();

                    MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtRbMemId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRbMemId.Text))
            {
                panel2.Visible = false;
                dataGridViewBooks.DataSource = null;
            }
        }

        private void btnRbCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
