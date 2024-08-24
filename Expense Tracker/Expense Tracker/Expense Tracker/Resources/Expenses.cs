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

namespace OOP_PROJECT.Resources
{
    public partial class Expenses : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HKQS9U5;Initial Catalog=\"Expense Tracker\";Integrated Security=SSPI");

        public Expenses()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        string username1;
        private void Name()
        {
            username1 = ExpensesUsernameLabel.Text;
        }

        string showBudget;
        private void ViewBudget()
        {
            Name();
            SqlCommand cm = new SqlCommand("SELECT budget FROM " + username1 + "Add_Budget", conn);
            conn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                showBudget = reader["budget"].ToString();
            }
            conn.Close();
        }

        private void BudgetBtn_Click(object sender, EventArgs e)
        {
            ViewBudget();
            MessageBox.Show($"Your Budget is {showBudget}");

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.HomeUsernameLabel.Text = ExpensesUsernameLabel.Text;
            this.Hide();
            home.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Name(ExpensesUsernameLabel.Text);
            deleteForm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Name();
            SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM " + username1 + "Add_Expenses", conn);
            conn.Open();

            DataTable dt = new DataTable();
            cm.Fill(dt);

            ExpenseTable.DataSource = dt;
            conn.Close();
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            Name();
            int cost1 = 0;
            SqlCommand cm = new SqlCommand("Select sum(Cost) as cost from " + username1 + "Add_Expenses", conn);
            conn.Open();
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(reader.GetOrdinal("cost")))
                {
                    string cost = reader["cost"].ToString();
                    cost1 = Convert.ToInt32(cost);
                }

            }
            conn.Close();
            ViewBudget();
            int showBudget1 = Convert.ToInt32(showBudget);
            int balance = showBudget1 - cost1;

            if (balance < 0)
            {
                MessageBox.Show("Enter your Budget first");

            }
            else
            {
                MessageBox.Show($"Your Balance is {balance.ToString()}");
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();
            this.Hide();
            loginform.ShowDialog();
        }

      
    }
}
