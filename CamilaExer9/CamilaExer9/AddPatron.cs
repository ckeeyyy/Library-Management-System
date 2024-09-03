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
    public partial class Patrons : Form
    {
        public Patrons()
        {
            InitializeComponent();
        }

        private void btnPSave_Click(object sender, EventArgs e)
        {
            if (txtPatronName.Text != "" && txtPatronMemId.Text != "")
            {
                String pName = txtPatronName.Text;
                Int64 pMemID = Convert.ToInt64(txtPatronMemId.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewPatron(pName, pMemID) values ('" + pName + "'," + pMemID + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Patron Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPatronName.Clear();
                txtPatronMemId.Clear();
            }
            else
            {
                MessageBox.Show("Empty Field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Unsaved DATA,", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
