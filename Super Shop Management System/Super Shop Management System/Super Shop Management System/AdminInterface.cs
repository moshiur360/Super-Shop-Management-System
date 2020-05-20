using System;
using System.Collections;
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
    public partial class AdminInterface : Form
    {
        public AdminInterface()
        {
            InitializeComponent();
            comboLoad();
            comboLoadEmployeeApprove();
            comboLoadEmployeeRemove();
        }

        public void comboLoad()
        {
            try
            {
                string query = "select name from product";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ArrayList arr = new ArrayList();

                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arr.Add(reader.GetString(0));
                    }
                    reader.NextResult();
                }
                cmbSelectedProduct.DataSource = arr;
                cmbUpdate.DataSource = arr;
                cmbPview.DataSource = arr;
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on Combo");
            }

        }

        public void comboLoadEmployeeApprove()
        {
            try
            {
                string query = "select name from data where approval=0";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ArrayList arr = new ArrayList();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        arr.Add(reader.GetString(0));
                    }
                    reader.NextResult();
                }
                cmbEmployeeApprove.DataSource = arr;
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on Combo");
            }
        }

        public void comboLoadEmployeeRemove()
        {
            try
            {
                string query = "select name from data where approval=1";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                ArrayList arr = new ArrayList();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    { 
                             arr.Add(reader.GetString(0));
                    }
                    reader.NextResult();
                }
                cmbEmployeeRemove.DataSource = arr;
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error on Combo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn f1 = new LogIn();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
            this.Hide();
        }

        private void btnPAdd_Click(object sender, EventArgs e)
        {
            string pName = txtPName.Text.Trim();
            string p = txtPPrice.Text.Trim();
            string q = txtPQantity.Text.Trim();
            string pvendor = txtPVendor.Text.Trim();
            int pQuantity = 0; ;
            float pPrice=0.0f;
            if (pName.Equals("") || p.Equals("") || q.Equals("") || pvendor.Equals(""))
            {
                MessageBox.Show("You have to fill all information ");
            }
            else
            {
                try
                {
                    pQuantity = Convert.ToInt32(q);
                    pPrice = float.Parse(p);
                    string query = "insert into product(name,price,quantity,vendor) values('" + pName + "'," + pPrice + "," + pQuantity + ",'" + pvendor + "')";
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
                    MessageBox.Show("Product Added!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong");
                }
                finally
                {
                    comboLoad();
                    txtPName.Text = "";
                    txtPPrice.Text = "";
                    txtPQantity.Text = "";
                    txtPVendor.Text = "";

                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string p = cmbSelectedProduct.Text;
                string query = "delete from product where name='" + p + "'";
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
                MessageBox.Show("Product Removed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccesfull");
            }
            finally
            {
                comboLoad();
            }
        }

        private void btnUpdatePPrice_Click(object sender, EventArgs e)
        {
            try
            {
                string product = cmbSelectedProduct.Text;
                string p = txtUpdatePPrice.Text;
                float price = 0.0f;
                price += float.Parse(p);

                string query = "update product set price=" + price + " where name='" + product + "';";
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
                MessageBox.Show("Product Price Updated");
                txtUpdatePPrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful , product price is not updated!");
            }
        }

        private void btnUpdatePQuantity_Click(object sender, EventArgs e)
        {
            string product = cmbSelectedProduct.Text;
            string q = txtUpdatePQuantity.Text;
            int newQuantity = 0;
            int existingQuantity = 0;
            newQuantity = int.Parse(q);
            try
            {
                string query = "select quantity from product where name='" + product + "';";
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-23HKVKR\\SQLEXPRESS;" +
                                           "database = Management;" +
                                             "integrated security = SSPI";
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.NextResult();
                while (reader.Read())
                {
                    existingQuantity = reader.GetInt32(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error from getting existing quantity");
            }
            int totalQuantity = existingQuantity + newQuantity;
            try
            {
                string query = "update product set quantity=" + totalQuantity + " where name='" + product + "';";
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
                MessageBox.Show("Product Quantity Updated");
                txtPQantity.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful , Quantity not updated!");
            }
        }

        private void btnPView_Click(object sender, EventArgs e)
        {
            string product = cmbPview.Text;
            string query = "select name,price,quantity from product where name='" + product + "';";
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
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridViewProduct.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful operation from view button");
            }
        }

        private void bntAllpView_Click(object sender, EventArgs e)
        {
            string query = "select name,price,quantity from product;";
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
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridViewProduct.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed from All product load");
            }
        }

        private void btnEmployeeApprove_Click(object sender, EventArgs e)
        {
            string employee = cmbEmployeeApprove.Text;
            try
            {
                string query = "update data set approval=1 where name='" + employee + "';";
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
                MessageBox.Show("Employee Approved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Approve Employee");
            }
            finally
            {
                cmbEmployeeApprove.Text = "";
                comboLoadEmployeeApprove();
                comboLoadEmployeeRemove();
            }

        }

        private void bntApprovalView_Click(object sender, EventArgs e)
        {
            string employee = cmbEmployeeApprove.Text;
            Console.WriteLine(employee);
            string query = "select name,address,phone,NID from data where name='"+employee+"';";
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
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridViewEmployee.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed from approval waiting grid load");
            }
            finally
            {
                comboLoadEmployeeApprove();
                comboLoadEmployeeRemove();
            }
        }

        private void btnEmployeeReject_Click(object sender, EventArgs e)
        {
            string employee = cmbEmployeeApprove.Text;
            try
            {
                string query = "update data set approval=-1 where name='" + employee + "';";
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
                MessageBox.Show("Employee Rejected");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Reject Employee");
            }
            finally
            {
                comboLoadEmployeeApprove();
            }
        }

        private void btnEmployeeRemove_Click(object sender, EventArgs e)
        {
            string employee = cmbEmployeeRemove.Text;
            try
            {
                string query = "delete from data where name='" + employee + "'";
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
                MessageBox.Show("Employee Removed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed from Employee Remove");
            }
            finally
            {
                comboLoadEmployeeRemove();
            }
          
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            string promo = txtPromoCode.Text;
            string percentage = txtPromoPercentage.Text;
            if(promo.Equals(""))
            {
                MessageBox.Show("Promo Text cant be blank!");
            }
            else if(percentage.Equals("") || int.Parse(percentage).Equals(0))
            {
                MessageBox.Show("Promo Text cant be blank or zero!");
            }
            else
            {
                string query = "insert into promotable (promo,percentage) values('" + promo + "','" + percentage + "');";
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
                    MessageBox.Show("Promo added succesfull");
                    txtPromoCode.Text = "";
                    txtPromoPercentage.Text = "";
                }
                catch
                {
                    MessageBox.Show("unsucessful to add Promo");
                }

            }
        }

        private void btnLessQuantity_Click(object sender, EventArgs e)
        {
            string query = "select name,price,quantity from product where quantity<5;";
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
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                gridViewProduct.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed from less quantity product load");
            }
        }

        private void CmbEmployeeApprove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
