using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class Signupform : Form
    {
        public Signupform()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HKQS9U5;Initial Catalog=\"Expense Tracker\";Integrated Security=True");
        private void LoginPageBtn_Click(object sender, EventArgs e)
        {
            Loginform loginform = new Loginform();
            this.Hide();
            loginform.ShowDialog();

        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {

            string email, username, password, gender;
            email = EmailField.Text;
            username = UsernameField.Text;
            password = PasswordField.Text;
            bool check = MaleBtn.Checked;
            if (check)
            {
                gender = MaleBtn.Text;
            }
            else
            {
                gender = FemaleBtn.Text;
            }

            try
            {


                SqlCommand cm = new SqlCommand("Select count(*) From signupusers where email='" + email + "' OR username='" + username + "'", conn);
                conn.Open();
                cm.Parameters.AddWithValue("email", email);
                cm.Parameters.AddWithValue("username", username);
                int count = Convert.ToInt32(cm.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Email or username already exists.");
                    return;
                }
                else if (email == "" || username == "" || password == "")
                {
                    MessageBox.Show("Please fill out all the fields");
                }
                else if (password.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long.");

                }
                else if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.");
                }else if(username.Contains(" "))
                {
                    MessageBox.Show("Username should not contain spaces.");

                }
                else
                {

                    SqlCommand cm1 = new SqlCommand("Insert Into signupusers (email,username,password,gender)Values('" + email + "', '" + username + "', '" + password + "', '" + gender + "')", conn);
                    SqlCommand cm2 = new SqlCommand("Create Table " +username+"Add_Budget (id INT NOT NULL, budget INT NOT NULL)", conn);
                    SqlCommand cm3 = new SqlCommand("Insert Into " + username + "Add_Budget (id, budget)Values(1,0)", conn);
                    SqlCommand cm4 = new SqlCommand("Create Table " + username + "Add_Expenses (Name Varchar(50) Not Null,Category Varchar(50) Not Null,Date Varchar(50) Not Null, Cost Int Not Null)", conn);

                    cm1.ExecuteNonQuery();
                    cm2.ExecuteNonQuery();
                    cm3.ExecuteNonQuery();
                    cm4.ExecuteNonQuery();

                    Home home = new Home();
                    home.HomeUsernameLabel.Text = username;
                    this.Hide();
                    home.Show();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
