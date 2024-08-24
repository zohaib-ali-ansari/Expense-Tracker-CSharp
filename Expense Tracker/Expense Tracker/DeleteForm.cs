using OOP_PROJECT.Resources;
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

namespace OOP_PROJECT
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        string username1;
        public void Name(string username)
        {
            username1 = username;
        }
        private void DeleteExpenseButton_Click(object sender, EventArgs e)
        {
            
            string nameForDeleting = DeleteExpenseField.Text;
            SqlConnection conn = null;

            if (nameForDeleting == "")
            {
                MessageBox.Show("Please Enter the Expense Name");
            }
            else
            {
                try
                {
                    conn = new SqlConnection("Data Source=DESKTOP-HKQS9U5;Initial Catalog=\"Expense Tracker\";Integrated Security=SSPI");
                    conn.Open();
                    SqlCommand cm = new SqlCommand("Delete from " + username1 + "Add_Expenses Where Name = '" + nameForDeleting + "'", conn);
                    cm.Parameters.AddWithValue("name", nameForDeleting);
                    int count = cm.ExecuteNonQuery();
                    if (count == 0)
                    {
                        MessageBox.Show("You Entered the wrong expense name");
                    }
                    else
                    {
                        conn = new SqlConnection("Data Source=DESKTOP-HKQS9U5;Initial Catalog=\"Expense Tracker\";Integrated Security=SSPI");
                        conn.Open();
                        SqlCommand cm1 = new SqlCommand("Delete from " + username1 + "Add_Expenses Where Name = '" + nameForDeleting + "'", conn);
                        cm1.ExecuteNonQuery();
                        MessageBox.Show("Expense has been deleted");
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void DeleteCloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}

