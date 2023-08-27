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

namespace PetManage
{
    internal class Category
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        private int Category_ID;
        private string Category_Name;
        private string Category_Des;
        public bool addCategory(int ID, string name, string Description)
        {
            Category_ID=ID;
            Category_Name=name;
            Category_Des=Description;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "INSERT INTO category(Cat_Name,Cat_Description,Cat_ID) VALUES(@Name,@Des,@ID)";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Name", Category_Name);
                    cmd.Parameters.AddWithValue("@Des", Category_Des);
                    cmd.Parameters.AddWithValue("@ID",Category_ID);
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
        public bool editCategory(int editID, string editName, string editDes, int CatID)
        {
            Category_ID = editID;
            Category_Name = editName;
            Category_Des = editDes;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "UPDATE category SET Cat_Name=@Edit_Name, Cat_Description=@Edit_Des, Cat_ID=@Edit_ID WHERE Cat_ID=@Cat_ID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@Edit_Name", Category_Name);
                    cmd.Parameters.AddWithValue("@Edit_Des", Category_Des);
                    cmd.Parameters.AddWithValue("@Edit_ID", Category_ID);
                    cmd.Parameters.AddWithValue("@Cat_ID", CatID);
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
        public bool removeCategory(int CatID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sqlQuery = "DELETE FROM category WHERE Cat_ID= @catID";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@catID", CatID);
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
        public DataTable getCategory()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM category";
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
        public void searchCategory()
        {

        }
        public void displayCategory(DataTable dataTable,DataGridView dataGridView)
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
