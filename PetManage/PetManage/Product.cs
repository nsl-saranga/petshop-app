using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//for the database......
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace PetManage
{
    internal class Product
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        
        private int Product_ID;
        private string Product_Name;
        private int Stock_Qty;
        private double Price;
        private int Category_ID;
        public bool addProduct(int ProID, string ProName, int Qty,double price,int CatID)
        {
            Product_ID = ProID;
            Product_Name = ProName;
            Stock_Qty = Qty;
            Price = price;
            Category_ID = CatID;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO Product(Pro_ID,Pro_Name,Pro_Quantity,Pro_Price,Cat_ID) VALUES(@ProID,@Name,@Qty,@Price,@CatID)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@ProID", Product_ID);
                    cmd.Parameters.AddWithValue("@Name", Product_Name);
                    cmd.Parameters.AddWithValue("@Qty", Stock_Qty);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@CatID", Category_ID);
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
        public bool editProduct(int EditProID, string EditProName, int EditQty, double Editprice, int EditCatID,int SelectedProID)
        {
            Product_ID = EditProID;
            Product_Name = EditProName;
            Stock_Qty = EditQty;
            Price = Editprice;
            Category_ID = EditCatID;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE Product SET  Pro_ID=@EditProID ,Pro_Name=@EditProName ,Pro_Quantity=@EditProQty, Pro_Price=@EditProPrice , Cat_ID=@EditCatID WHERE Pro_ID=@Pro_ID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@EditProID", Product_ID);
                    cmd.Parameters.AddWithValue("@EditProName", Product_Name);
                    cmd.Parameters.AddWithValue("@EditProQty", Stock_Qty);
                    cmd.Parameters.AddWithValue("@EditProPrice", Price);
                    cmd.Parameters.AddWithValue("@EditCatID", Category_ID);
                    cmd.Parameters.AddWithValue("@Pro_ID", SelectedProID);
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
        public bool removeProduct(int ProID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "DELETE FROM Product WHERE Pro_ID= @ProID"; ;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@ProID", ProID);
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
        public DataTable getProduct()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Product";
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
        public DataTable searchProductByCategory(int selectedCatID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Product WHERE Cat_ID=@selectedCatID";
                    SqlCommand cmd= new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@selectedCatID", selectedCatID);
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);//created using cmd.
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
        public DataTable searchProduct(int selectedProID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Product WHERE Pro_ID=@selectedProID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@selectedProID", selectedProID);
                    SqlDataAdapter sqlData = new SqlDataAdapter(cmd);//created using cmd.
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

        /*public bool updateQty(DataGridView dataGridView)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {

                        conn.Open();
                        string sqlQuery = "UPDATE Product SET Pro_Quantity-=@Qty WHERE Pro_ID=@ProID";
                        SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(row.Cells[2].Value));
                        cmd.Parameters.AddWithValue("@ProID", Convert.ToInt32(row.Cells[0].Value));
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }*/

        public bool decreaseStockQty(int proID,int Qty)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "UPDATE Product SET Pro_Quantity-=@Qty WHERE Pro_ID=@ProID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@ProID", proID);
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
        public bool increaseStockQty(int proID, int Qty)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "UPDATE Product SET Pro_Quantity+=@Qty WHERE Pro_ID=@ProID";
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Qty", Qty);
                    cmd.Parameters.AddWithValue("@ProID", proID);
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
        public void displayProduct(DataTable dataTable, DataGridView dataGridView)
        {
            //datagridview design
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = false;
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //give the datasource
            dataGridView.DataSource = dataTable;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
        }
    
    }     
}
