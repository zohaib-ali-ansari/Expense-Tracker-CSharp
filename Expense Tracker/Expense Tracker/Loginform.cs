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

    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-HKQS9U5;Initial Catalog=\"Expense Tracker\";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                String username, password;

                username = UsernameField.Text;
                password = PasswordField.Text;

                

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM signupusers WHERE username = '" + username + "'AND password = '" + password + "'", conn);
                conn.Open();
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    
                    Home home = new Home();
                    home.HomeUsernameLabel.Text = username;
                    this.Hide();
                    home.ShowDialog();
                    
                   
                }
                else
                {
                    MessageBox.Show("Invalid Login credentials");

                    UsernameField.Clear();
                    PasswordField.Clear();

                    UsernameField.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { conn.Close(); }


        }

        private void LoginPageBtn_Click(object sender, EventArgs e)
        {
            Signupform signupform = new Signupform();
            this.Hide();
            signupform.ShowDialog();
        }

  
    }
}
