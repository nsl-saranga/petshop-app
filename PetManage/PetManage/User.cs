using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;

namespace PetManage
{
    internal class User
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        protected string username;
        protected string password;
        public bool isAuthenticated(string Inputusername, string Inputpassword, int comboxIndex)
        {
            username = Inputusername;
            password = Inputpassword;

            string sqlQuery;
            if (comboxIndex == 0)
                sqlQuery = "SELECT * FROM Owner WHERE LoginUsername=@EnteredUserename AND LoginPassword=@EnteredPW";
            else
                sqlQuery = "SELECT * FROM Cashier WHERE CashierLoginUsername=@EnteredUserename AND CashierLoginPassword=@EnteredPW";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, conn);
                    sqlData.SelectCommand.Parameters.AddWithValue("@EnteredUserename", Inputusername);
                    sqlData.SelectCommand.Parameters.AddWithValue("@EnteredPW", Inputpassword);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    if (dt.Rows.Count != 0)
                        return true;
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void displayUser(DataTable dataTable,DataGridView dataGridView)
        {
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = false;
            dataTable.DefaultView.Sort = string.Empty;
            //give the datasource
            dataGridView.DataSource = dataTable;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
        }           
    }    
}
