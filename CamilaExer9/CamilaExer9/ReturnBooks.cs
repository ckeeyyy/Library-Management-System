using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CamilaExer9
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet6.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter3.Fill(this.libraryManagementDataSet6.CRBook);
            // TODO: This line of code loads data into the 'libraryManagementDataSet4.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter2.Fill(this.libraryManagementDataSet4.CRBook);
            // TODO: This line of code loads data into the 'libraryManagementDataSet3.CRBook' table. You can move, or remove it, as needed.
            this.cRBookTableAdapter1.Fill(this.libraryManagementDataSet3.CRBook);
            // Clear the DataGridView when the form loads
            dataGridViewBooks.DataSource = null;
            panel2.Visible = false;
            txtRbMemId.Clear();
        }

        private void txtRbSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select * from CRBook where pt_memId = @MemId and bk_return_date IS NULL", con);
                cmd.Parameters.AddWithValue("@MemId", txtRbMemId.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridViewBooks.DataSource = ds.Tables[0];
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
            panel2.Visible = true;

            if (dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Convert.ToInt64(dataGridViewBooks.Rows[e.RowIndex].Cells[0].Value);
                btitle = dataGridViewBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                bdate = dataGridViewBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
                bdate1 = dataGridViewBooks.Rows[e.RowIndex].Cells[5].Value.ToString();

            }

            txtRbTitle.Text = btitle;
            txtRbCheckOutDate.Text = bdate;
            txtRbDueDate.Text = bdate1;
        }

        private void btnRbReturn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                try
                {
                    con.Open();

                    DateTime actualReturnDate = dateTimePicker1.Value;
                    DateTime dueDate = GetDueDateForBook(rowid); // Method to retrieve bk_due_date
                    bool isOverdue = actualReturnDate > dueDate;
                    int overdueDays = (isOverdue) ? (actualReturnDate - dueDate).Days : 0;

                    // Update the bk_actual_return_date, bk_is_overdue, and bk_overdue_days in the CRBook table
                    SqlCommand cmd = new SqlCommand("UPDATE CRBook SET bk_return_date = @ActualReturnDate, bk_is_overdue = @IsOverdue WHERE pt_memId = @MemId ", con);
                    cmd.Parameters.AddWithValue("@ActualReturnDate", actualReturnDate);
                    cmd.Parameters.AddWithValue("@IsOverdue", isOverdue);
                    cmd.Parameters.AddWithValue("@MemId", txtRbMemId.Text);
                    cmd.Parameters.AddWithValue("@RowId", rowid);
                    cmd.ExecuteNonQuery();

                    // Update the quantity of the returned book in the NewBook table
                    SqlCommand updateQuantityCmd = new SqlCommand("UPDATE NewBook SET bQuantity = bQuantity + 1 WHERE bTitle = @BookTitle", con);
                    updateQuantityCmd.Parameters.AddWithValue("@BookTitle", btitle);
                    updateQuantityCmd.ExecuteNonQuery();

                    MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the form to refresh the data
                    ReturnBooks_Load(this, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DateTime GetDueDateForBook(long rowid)
        {
            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT due_date FROM CRBook WHERE id = @RowId", con);
                cmd.Parameters.AddWithValue("@RowId", rowid);

                con.Open();
                return (DateTime)cmd.ExecuteScalar();
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
