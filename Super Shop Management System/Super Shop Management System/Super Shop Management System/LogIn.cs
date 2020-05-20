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

namespace Super_Shop_Management_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            pictureBox1.Image = Image.FromFile(@"C: \Users\iftek\source\repos\Super Shop Management System\logo.jpg");
        
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPassword.Text;
            string p = "@#";
            int approval = 0;
            int status = 0;
            string query = "select password,approval,status from data where username='" +
                          userName + "';";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                       "database = Management;" +
                                         "integrated security = SSPI";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    p = reader.GetString(0);
                    approval = reader.GetInt32(1);
                    status = reader.GetInt32(2);
                }
                reader.NextResult();
            }
            con.Close();
            if (password == "")
            {
                MessageBox.Show("Username and Password cant be blank!");
            }
            else if (password.Equals(p) && approval == 0)
            {
                MessageBox.Show("Your account is not approved yet");
            }
            else if (password.Equals(p) && approval == 1)
            {
                UserInterface ui = new UserInterface();
                this.Hide();
                ui.Closed += (s, args) => this.Close();
                ui.Show();
            }
            else if (password == p && approval == 2 )
            {
                AdminInterface ai = new AdminInterface();
                this.Hide();
                ai.Closed += (s, args) => this.Close();
                ai.Show();
                // MessageBox.Show("Your Account is not approved yet !");
            }
            else
                MessageBox.Show("Invalid username or password");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.ResetText();
            txtPassword.ResetText();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAccountForm f2 = new CreateAccountForm();
            this.Hide();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
        }

    }
}
