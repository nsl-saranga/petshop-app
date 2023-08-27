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
using System.Globalization;
using System.Diagnostics;

namespace PetManage
{
    internal class Purchase
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        private int PurchaseID;
        private int ProductID;
        private int SellerID;
        private string PurchasedDate;
        private int PurchasedQty;
        private double PurchasedPrice;

        public bool addPurchase(int pur_ID,int pro_ID,int sell_ID, string date, int qty, double price)
        {
            PurchaseID= pur_ID;
            ProductID = pro_ID;
            SellerID= sell_ID;
            PurchasedDate = date;
            PurchasedQty = qty;
            PurchasedPrice = price;
            DateTime parsedDate = DateTime.ParseExact(PurchasedDate, "d/M/yyyy", CultureInfo.InvariantCulture);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO Purchase(Purchase_ID,Pro_ID,Seller_ID,Date,Quantity,Purchased_Price) VALUES(@PurID,@ProID,@SellerID,@Date,@Qty,@Price)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@PurID", PurchaseID);
                    cmd.Parameters.AddWithValue("@ProID", ProductID);
                    cmd.Parameters.AddWithValue("@SellerID", SellerID);
                    cmd.Parameters.AddWithValue("@Date", parsedDate);
                    cmd.Parameters.AddWithValue("@Qty", PurchasedQty);
                    cmd.Parameters.AddWithValue("@Price", PurchasedPrice);
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
        public bool editPurchase(int pur_ID, int pro_ID, int sell_ID, string date, int qty, double price,int selectedID)
        {
            PurchaseID = pur_ID;
            ProductID = pro_ID;
            SellerID = sell_ID;
            PurchasedDate = date;
            PurchasedQty = qty;
            PurchasedPrice = price;
            DateTime parsedDate = DateTime.ParseExact(PurchasedDate, "d/M/yyyy", CultureInfo.InvariantCulture);
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE Purchase SET  Purchase_ID=@EditPurID ,Pro_ID=@EditProID ,Seller_ID=@EditSellerID ,Date=@EditDate, Quantity=@EditQty, Purchased_Price=@EditPrice WHERE Purchase_ID=@PurID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@EditPurID", PurchaseID);
                    cmd.Parameters.AddWithValue("@EditProID", ProductID);
                    cmd.Parameters.AddWithValue("@EditSellerID", SellerID);
                    cmd.Parameters.AddWithValue("@EditDate", parsedDate);
                    cmd.Parameters.AddWithValue("@EditQty", PurchasedQty);
                    cmd.Parameters.AddWithValue("@EditPrice", PurchasedPrice);
                    cmd.Parameters.AddWithValue("@PurID", selectedID);
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
        public bool removePurchase(int selectedID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "DELETE FROM Purchase WHERE Purchase_ID=@PurID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@PurID", selectedID);
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
        public DataTable getPurchase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Purchase";
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
        public void displayPurchase(DataTable dataTable, DataGridView dataGridView)
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
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
        }
    }
}

