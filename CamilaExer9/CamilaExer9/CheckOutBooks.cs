using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CamilaExer9
{
    public partial class CheckOutBooks : Form
    {
        public CheckOutBooks()
        {
            InitializeComponent();
        }

        private void CheckOutBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryManagementDataSet9.NewBook' table. You can move, or remove it, as needed.
            this.newBookTableAdapter.Fill(this.libraryManagementDataSet9.NewBook);
            comboBoxBooks.Items.Clear();

            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT bTitle FROM NewBook", con))
                    {
                        SqlDataReader Sdr = cmd.ExecuteReader();

                        if (Sdr.HasRows)
                        {
                            while (Sdr.Read())
                            {
                                comboBoxBooks.Items.Add(Sdr.GetString(0));
                            }
                        }
                        else
                        {
                            MessageBox.Show("No books found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

            // Add event handler for comboBoxBooks
            comboBoxBooks.SelectedIndexChanged += comboBoxBooks_SelectedIndexChanged;
        }

        private void comboBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Fetch the ISBN for the selected book title
            if (comboBoxBooks.SelectedIndex != -1)
            {
                string selectedTitle = comboBoxBooks.SelectedItem.ToString();

                using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
                {
                    try
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("SELECT bISBN FROM NewBook WHERE bTitle = @Title", con))
                        {
                            cmd.Parameters.AddWithValue("@Title", selectedTitle);

                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                txtCbISBN.Text = result.ToString();
                            }
                            else
                            {
                                txtCbISBN.Clear();
                                MessageBox.Show("ISBN not found for the selected book.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        int count;

        private void btnSearchPatron_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCbMemId.Text))
            {
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM NewPatron WHERE pMemID = @MemId", con);
                        cmd.Parameters.AddWithValue("@MemId", txtCbMemId.Text);

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);

                        cmd.CommandText = "SELECT COUNT(pt_memId) FROM CRBook WHERE pt_memId = @MemId AND bk_return_date IS NULL";
                        con.Open();
                        count = (int)cmd.ExecuteScalar();

                        if (DS.Tables[0].Rows.Count != 0)
                        {
                            txtCbName.Text = DS.Tables[0].Rows[0]["pName"].ToString();
                            txtMemId.Text = DS.Tables[0].Rows[0]["pMemID"].ToString();
                        }
                        else
                        {
                            txtCbName.Clear();
                            txtMemId.Clear();
                            MessageBox.Show("Invalid Membership ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCbName.Text))
            {
                if (comboBoxBooks.SelectedIndex != -1 && count <= 2)
                {
                    string name = txtCbName.Text;
                    Int64 memId = Convert.ToInt64(txtMemId.Text);
                    string bookTitle = comboBoxBooks.Text;
                    Int64 Isbn = Convert.ToInt64(txtCbISBN.Text);
                    DateTime bookCheckOutDate = dateTimePicker1.Value;
                    
                    DateTime bookDueDate = dateTimePicker2.Value; // Get the return date from dateTimePicker2

                    int newQuantity = UpdateBookQuantity(bookTitle);

                    if (newQuantity >= 0)
                    {
                        using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
                        {
                            try
                            {
                                SqlCommand cmd = new SqlCommand("INSERT INTO CRBook (pt_name, pt_memId, bk_title, bk_checkout_date, due_date, bk_ISBN) VALUES (@Name, @MemId, @BookTitle, @CheckOutDate, @DueDate, @ISBN)", con);
                                cmd.Parameters.AddWithValue("@Name", name);
                                cmd.Parameters.AddWithValue("@MemId", memId);
                                cmd.Parameters.AddWithValue("@BookTitle", bookTitle);
                                cmd.Parameters.AddWithValue("@CheckOutDate", bookCheckOutDate);
                                cmd.Parameters.AddWithValue("@DueDate", bookDueDate);
                                cmd.Parameters.AddWithValue("@ISBN", Isbn);

                                con.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Book Checked Out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The selected book is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Select Book, OR Maximum number of Book has been Checked Out", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Membership ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int UpdateBookQuantity(string bookTitle)
        {
            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT bQuantity FROM NewBook WHERE bTitle = @BookTitle", con);
                    cmd.Parameters.AddWithValue("@BookTitle", bookTitle);

                    con.Open();
                    int currentQuantity = Convert.ToInt32(cmd.ExecuteScalar());

                    if (currentQuantity > 0)
                    {
                        int newQuantity = currentQuantity - 1;
                        cmd.CommandText = "UPDATE NewBook SET bQuantity = @NewQuantity WHERE bTitle = @BookTitle";
                        cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        cmd.ExecuteNonQuery();

                        return newQuantity;
                    }
                    else
                    {
                        return -1; // Out of stock
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void txtCbMemId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCbMemId.Text))
            {
                txtCbName.Clear();
                txtMemId.Clear();
                comboBoxBooks.SelectedIndex = -1;
                txtCbISBN.Clear();
            }
        }
    }
}
