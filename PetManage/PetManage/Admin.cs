using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for the database......
using System.Configuration;
using System.Data;
using System.Drawing;

namespace PetManage
{
    internal class Admin : User
    {
        public int AdminID;
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public bool addAdmin(int inputAdminID, string inputAdminUsername, string inputAdminPW)
        {
            AdminID = inputAdminID;
            username = inputAdminUsername;
            password = inputAdminPW;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO Owner(Owner_ID,LoginUserName,LoginPassword) VALUES(@OwnerID,@OwnerUname,@OwnerPW)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@OwnerID", AdminID);
                    cmd.Parameters.AddWithValue("@OwnerUname", username);
                    cmd.Parameters.AddWithValue("@OwnerPW", password);
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
        public bool editAdmin(int inputAdminID, string inputAdminUsername, string inputAdminPW, int selectedAdminID)
        {
            AdminID = inputAdminID;
            username = inputAdminUsername;
            password = inputAdminPW;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE Owner SET Owner_ID=@EditOwnerID ,LoginUsername=@EditOwnerUname ,LoginPassword=@EditOwnerPW WHERE Owner_ID=@OwnerID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@EditOwnerID", AdminID);
                    cmd.Parameters.AddWithValue("@EditOwnerUname", username);
                    cmd.Parameters.AddWithValue("@EditOwnerPW", password);
                    cmd.Parameters.AddWithValue("@OwnerID", selectedAdminID);
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

        public bool removeAdmin(int Selected_ID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "DELETE FROM Owner WHERE Owner_ID=@SelectedID"; ;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@SelectedID", Selected_ID);
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

        public DataTable getAdmin()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Owner";
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
