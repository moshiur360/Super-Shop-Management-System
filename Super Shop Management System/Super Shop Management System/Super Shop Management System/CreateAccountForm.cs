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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string address = txtAddress.Text;
            string NID = txtNID.Text;
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmpassword = txtConfirmPassword.Text;
            string DOB = dateTimePicker1.Text.ToString();
            string phone = txtMobile.Text;
            Boolean agree = false;
            int gender = 0;
            bool isChecked = rbMale.Checked;
            if (isChecked)
                gender = 1;
            else
                gender = 2;
            if (cbAgreement.Checked)
                agree = true;
            else
            {

            }
            if (name == "" || address == "" || NID == "" || username == "" || password == "")
                MessageBox.Show("You have to fill all item!");
            else if (password != confirmpassword)
                MessageBox.Show("Password not matched");
            else if (agree != true)
            {
                MessageBox.Show("You have to agree with the shop's policy");
            }
            else
            {
                //String query = "insert into data([name],[address],[password],username,phone,NID,gender,dateofbirth,approval,[status]) values('" + name + "','" + address + "','" + password + "','" + username + "','" + phone + "','" + NID + "'," + gender + ",'" + DOB + "',0,0);";
                String query = "insert into data(name,address,password,username,phone,NID,gender,dateofbirth,approval,status) values('"+name+"','"+address+"','"+password+"','"+username+"','"+phone+"','"+NID+"',"+gender+",'"+DOB+"',0,0)";
                try
                { 
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                               "database = Management;" +
                                                 "integrated security = SSPI";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    con.Open();
                 
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully created your account , wait for the Manager approval");
                    LogIn f1 = new LogIn();
                    f1.Closed += (s, args) => this.Close();
                    f1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccessfull!");
                    Console.WriteLine(ex);

                }

            }


        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
            this.Hide();
        }


    }
}
