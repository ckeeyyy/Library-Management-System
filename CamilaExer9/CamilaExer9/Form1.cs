using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamilaExer9
{
    public partial class Form1 : Form
    {

        private string ConnectionString = "data source = LAPTOP-7DELVKGD\\SQLEXPRESS; database = LibraryManagement;integrated security=True";
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!backgroundWorker1.CancellationPending)
            {
                // Fetch overdue books since last checked date
                string sql = "SELECT * FROM CRBook WHERE bk_return_date is NULL AND due_date <= @lastCheckedDate ;";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@lastCheckedDate", DateTime.Now.ToString("yyyy-MM-dd"));

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Notify user about overdue book
                                string bookName = reader["bk_title"].ToString();
                                string checkedName = reader["pt_name"].ToString();
                                ShowNotification($"Book '{bookName}' is overdue!" +
                                                 $" Checkouted by {checkedName}");
                            }
                        }


                    }

                }

                Thread.Sleep(3600000); //Checks every Hour
            }
        }

        private void ShowNotification(string message)
        {

            MessageBox.Show(message, "Overdue Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void addNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewBooks abs = new AddNewBooks();
            abs.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks vbs = new ViewBooks();
            vbs.Show();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patrons addPatron = new Patrons();
            addPatron.Show();
        }

        private void viewPatronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPatrons vp = new ViewPatrons();
            vp.Show();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutBooks cob = new CheckOutBooks();
            cob.Show();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetails bd = new BookDetails();
            bd.Show();
        }

       
    }
}
