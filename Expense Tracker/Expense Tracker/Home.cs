using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using OOP_PROJECT.Resources;
using Microsoft.VisualBasic;

namespace OOP_PROJECT
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HKQS9U5;Initial Catalog=\"Expense Tracker\";Integrated Security=SSPI");


        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        string username1;
        private void Name()
        {
            username1 = HomeUsernameLabel.Text;
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



        int balance;
        int cost1 = 0;

        private void ViewBalance()
        {
            Name();
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
            balance = showBudget1 - cost1;
        }

        private void AddBudgetBtn_Click(object sender, EventArgs e)
        {
            Name();

            int budget;

            ViewBalance();
            int cost2 = cost1;

            if (!int.TryParse(AddBudgetField.Text, out budget) || budget <= 0)
            {
                MessageBox.Show("Please enter a valid amount");
            }
            else if (budget < cost2)
            {
                MessageBox.Show("Your expenses more than your budget");

            }

            else
            {

                try
                {
                    SqlCommand cm = new SqlCommand("update " + username1 + "Add_Budget set budget='" + budget + "' where id=1", conn);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Your Budget has been Added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }


        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            Name();
            ViewBalance();
            int balance1 = Convert.ToInt32(balance);
            string prdName, prdCategory, date;
            string prdCost;
            prdName = PrdNameField.Text;
            prdCategory = PrdCategoryField.Text;
            date = PrdDateField.Text;
            prdCost = PrdCostField.Text;

            int prdCost1 ;

            if (prdName == "" || prdCategory == "" || date == "" || prdCost == "")
            {
                MessageBox.Show("Please fill out all the fields");
            }
      
            else if (!int.TryParse(prdCost, out prdCost1))
            {
                MessageBox.Show("Please enter a valid amount");
            }
            else if (balance1 < prdCost1)
            {
                MessageBox.Show("Low Budget");

            }
            else
            {
                try
                {
                    SqlCommand cm = new SqlCommand("INSERT INTO " + username1 + "Add_Expenses(Name,Category,Date,Cost) VALUES ('" + prdName + "','" + prdCategory + "','" + date + "','" + prdCost + "')", conn);
                    conn.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Your Expense has been Added");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }


        private void BudgetBtn_Click(object sender, EventArgs e)
        {
            ViewBudget();
            MessageBox.Show($"Your Budget is {showBudget}");
        }

        private void ExpensesBtn_Click_1(object sender, EventArgs e)
        {


            try
            {
                Name();
                SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM " + username1 + "Add_Expenses", conn);
                conn.Open();

                DataTable dt = new DataTable();
                cm.Fill(dt);

                Expenses expenses = new Expenses();
                expenses.ExpenseTable.DataSource = dt;
                expenses.ExpensesUsernameLabel.Text = HomeUsernameLabel.Text;
                //DeleteForm deleteForm = new DeleteForm();
                //deleteForm.Name(HomeUsernameLabel.Text);
                this.Hide();
                expenses.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            ViewBalance();
            if (balance < 0)
            {
                MessageBox.Show("Enter your budget first");

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

