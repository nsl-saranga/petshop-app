using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PetManage
{
    internal class Cashier:User
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        private int CashierID;
        private string CashierName;
        private char CashierGender;
        private string CashierMobile;

        public bool addCashier(int inputCashierID, string inputUsername, string inputPassword,string inputCashierName,char inputCashierGender,string inputCashierMobile)
        {
            CashierID = inputCashierID;
            username = inputUsername;
            password = inputPassword;
            CashierName = inputCashierName;
            CashierGender = inputCashierGender;
            CashierMobile = inputCashierMobile;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO Cashier(Cashier_ID,CashierLoginUsername,CashierLoginPassword,CashierName,CashierGender,CashierMobile) VALUES(@CashierID,@CashierUname,@CashierPW,@CashierName,@CashierGender,@CashierMobile)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@CashierID", CashierID);
                    cmd.Parameters.AddWithValue("@CashierUname", username);
                    cmd.Parameters.AddWithValue("@CashierPW", password);
                    cmd.Parameters.AddWithValue("@CashierName", CashierName);
                    cmd.Parameters.AddWithValue("@CashierGender", CashierGender);
                    cmd.Parameters.AddWithValue("@CashierMobile", CashierMobile);
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
        public bool editCashier(int inputCashierID, string inputUsername, string inputPassword, string inputCashierName, char inputCashierGender, string inputCashierMobile,int selectedCashierID)
        {
            CashierID = inputCashierID;
            username = inputUsername;
            password = inputPassword;
            CashierName = inputCashierName;
            CashierGender = inputCashierGender;
            CashierMobile = inputCashierMobile;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE Cashier SET Cashier_ID=@EditCashierID ,CashierLoginUsername=@EditCashierUname ,CashierLoginPassword=@EditCashierPW,CashierName=@EditCashierName, CashierGender=@EditCashierGender,CashierMobile=@EditCashierMobile WHERE Cashier_ID=@CashierID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@EditCashierID", CashierID);
                    cmd.Parameters.AddWithValue("@EditCashierUname", username);
                    cmd.Parameters.AddWithValue("@EditCashierPW", password);
                    cmd.Parameters.AddWithValue("@EditCashierName", CashierName);
                    cmd.Parameters.AddWithValue("@EditCashierGender", CashierGender);
                    cmd.Parameters.AddWithValue("@EditCashierMobile", CashierMobile);
                    cmd.Parameters.AddWithValue("@CashierID", selectedCashierID);
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

        public bool removeCashier(int Selected_ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "DELETE FROM Cashier WHERE Cashier_ID= @CashierID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@CashierID", Selected_ID);
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

        public DataTable getCashier()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Cashier";
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
    }
}
