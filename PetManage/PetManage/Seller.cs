using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for the database......
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace PetManage
{
    internal class Seller
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        private int SellerID;
        private string SellerName;
        private string SellerAddress;
        private string SellerEmail;
        private string SellerPhone;

        public bool addSeller(int sellerID, string name, string address,string email,string phone)
        {
            SellerID = sellerID;
            SellerName=name;
            SellerAddress=address;
            SellerEmail = email;
            SellerPhone = phone;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO Seller(Seller_ID,Seller_Name,Seller_Address,Seller_Email,Seller_Telephone) VALUES(@SellerID,@Name,@Add,@Email,@Tel)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@SellerID", SellerID);
                    cmd.Parameters.AddWithValue("@Name", SellerName);
                    cmd.Parameters.AddWithValue("@Add", SellerAddress);
                    cmd.Parameters.AddWithValue("@Email", SellerEmail);
                    cmd.Parameters.AddWithValue("@Tel", SellerPhone);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool editSeller(int editID, string editName, string editAdd, string editEmail,string editPhone,int selectedID)
        {
            SellerID = editID;
            SellerName = editName;
            SellerAddress =editAdd;
            SellerEmail = editEmail;
            SellerPhone = editPhone;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE Seller SET Seller_ID=@EditSellerID,Seller_Name=@EditName,Seller_Address=@EditAdd,Seller_Email=@EditEmail,Seller_Telephone=@EditTel   WHERE Seller_ID=@Seller_ID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@EditSellerID", SellerID);
                    cmd.Parameters.AddWithValue("@EditName", SellerName);
                    cmd.Parameters.AddWithValue("@EditAdd", SellerAddress);
                    cmd.Parameters.AddWithValue("@EditEmail", SellerEmail);
                    cmd.Parameters.AddWithValue("@EditTel", SellerPhone);
                    cmd.Parameters.AddWithValue("@Seller_ID",selectedID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool removeSeller(int selectedSellerID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "DELETE FROM Seller WHERE Seller_ID=@SellerID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@SellerID", selectedSellerID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable getSeller()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Seller";
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, conn);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    conn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void displaySeller(DataTable dataTable, DataGridView dataGridView)
        {
            //datagridview design
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
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}
