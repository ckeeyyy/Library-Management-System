using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CamilaExer9
{
    public partial class ViewPatrons : Form
    {
        public ViewPatrons()
        {
            InitializeComponent();
            txtVpMemId.ReadOnly = true; // Make the Membership ID TextBox read-only
        }

        private void ViewPatrons_Load(object sender, EventArgs e)
        {
            // Load data into the NewPatron table
            this.newPatronTableAdapter.Fill(this.libraryManagementDataSet2.NewPatron);
            panel2.Visible = false;

            RefreshPatronData();
        }

        Int64 pMemID;

        private void dataGridViewPatrons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPatrons.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                pMemID = Int64.Parse(dataGridViewPatrons.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            panel2.Visible = true;

            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select * from NewPatron where pMemID = @pMemID", con);
                cmd.Parameters.AddWithValue("@pMemID", pMemID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                txtVpName.Text = ds.Tables[0].Rows[0]["pName"].ToString();
                txtVpMemId.Text = ds.Tables[0].Rows[0]["pMemID"].ToString();
            }
        }

        private void btnVpCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {
            string filter = txtPName.Text;
            string query = string.IsNullOrEmpty(filter) ? "Select * from NewPatron" : "Select * from NewPatron where pName LIKE @filter";

            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (!string.IsNullOrEmpty(filter))
                {
                    cmd.Parameters.AddWithValue("@filter", filter + "%");
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewPatrons.DataSource = ds.Tables[0];
            }
        }

        private void btnVpRefresh_Click(object sender, EventArgs e)
        {
            txtPName.Clear();
            panel2.Visible = false;
            RefreshPatronData();
        }

        private void RefreshPatronData()
        {
            using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand("Select * from NewPatron", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridViewPatrons.DataSource = ds.Tables[0];
            }
        }

        private void btnVpUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Patron details will be updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string pName = txtVpName.Text;

                using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
                {
                    con.Open();

                    // Update the NewPatron table
                    using (SqlCommand cmd = new SqlCommand("UPDATE NewPatron SET pName = @pName WHERE pMemID = @pMemID", con))
                    {
                        cmd.Parameters.AddWithValue("@pName", pName);
                        cmd.Parameters.AddWithValue("@pMemID", pMemID);
                        cmd.ExecuteNonQuery();
                    }

                    // Update the CRBook table
                    using (SqlCommand cmd = new SqlCommand("UPDATE CRBook SET pt_name = @pName WHERE pt_memId = @pMemID", con))
                    {
                        cmd.Parameters.AddWithValue("@pName", pName);
                        cmd.Parameters.AddWithValue("@pMemID", pMemID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Patron details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnVpDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Patron will be deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection("data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True"))
                {
                    con.Open();

                    // Delete from the NewPatron table
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM NewPatron WHERE pMemID = @pMemID", con))
                    {
                        cmd.Parameters.AddWithValue("@pMemID", pMemID);
                        cmd.ExecuteNonQuery();
                    }

                    // Delete from the CRBook table
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM CRBook WHERE pt_memId = @pMemID", con))
                    {
                        cmd.Parameters.AddWithValue("@pMemID", pMemID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Patron deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
