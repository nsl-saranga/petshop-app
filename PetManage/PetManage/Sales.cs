using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for the database......
using System.Configuration;
using System.Globalization;
using System.Drawing;
using System.Security.Cryptography;

namespace PetManage
{
    internal class Sales
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private int ProductID;
        private int SoldQty;
        private double TotalRevenue;
        private string Date;
        private string Time;
       

        public bool recordSales(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        ProductID = Convert.ToInt32(row.Cells[0].Value);
                        SoldQty = Convert.ToInt32(row.Cells[2].Value);
                        TotalRevenue = Convert.ToDouble(row.Cells[4].Value);
                        Date = row.Cells[5].Value.ToString();
                        Time = row.Cells[6].Value.ToString();
                        DateTime parsedDate = DateTime.ParseExact(Date, "d/M/yyyy", CultureInfo.InvariantCulture);

                        conn.Open();
                        string sqlQuery = "INSERT INTO Sales (Pro_ID,Sold_Qty,Revenue,Date,Time) VALUES(@ProID,@Qty,@Rev,@Date,@Time)";
                        SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                        cmd.Parameters.AddWithValue("@ProID", ProductID);
                        cmd.Parameters.AddWithValue("@Qty", SoldQty);
                        cmd.Parameters.AddWithValue("@Rev", TotalRevenue);
                        cmd.Parameters.AddWithValue("@Date", parsedDate);
                        cmd.Parameters.AddWithValue("@Time", Time);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public DataTable getAllSales()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Sales";
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
        public DataTable getMonthlySales(TextBox proIDTxtBox, DateTimePicker dtPicker)
        {
            string sqlQuery = "";
            if (proIDTxtBox.Text == "")
                sqlQuery = "SELECT * FROM Sales WHERE MONTH(Date)=@selectedMonth AND YEAR(Date)=@selectedYear";
            else
                sqlQuery = "SELECT * FROM Sales WHERE MONTH(Date)=@selectedMonth AND YEAR(Date)=@selectedYear AND Pro_ID=@selectedID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, conn);
                    if(proIDTxtBox.Text=="")
                    {
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedYear ", int.Parse(dtPicker.Value.Year.ToString()));
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedMonth ", int.Parse(dtPicker.Value.Month.ToString()));
                    }
                    else
                    {
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedID ", int.Parse(proIDTxtBox.Text));
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedYear ", int.Parse(dtPicker.Value.Year.ToString()));
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedMonth ", int.Parse(dtPicker.Value.Month.ToString()));
                    }
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
        public DataTable getDailySales(TextBox proIDTxtBox,DateTimePicker dtPicker) 
        {
            DateTime parsedDate = DateTime.ParseExact(dtPicker.Value.ToString("d/M/yyyy"), "d/M/yyyy", CultureInfo.InvariantCulture);
            string sqlQuery = "";
            if (proIDTxtBox.Text == "")
                sqlQuery = "SELECT * FROM Sales WHERE Date=@selectedDate";
            else
                sqlQuery = "SELECT * FROM Sales WHERE Date=@selectedDate AND Pro_ID=@selectedID";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, conn);
                    if(proIDTxtBox.Text=="")
                    {
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedDate ", parsedDate);
                    }
                    else
                    {
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedID ", int.Parse(proIDTxtBox.Text));
                        sqlData.SelectCommand.Parameters.AddWithValue("@selectedDate ", parsedDate);
                    }
                    DataTable dt= new DataTable();
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
        public int calculateMonthlySoldQty(int inputProId,DateTimePicker dtPicker)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT Sold_Qty FROM Sales WHERE Pro_ID=@selectedID AND Month(Date)=@selectedMonth AND Year(Date)=@selectedYear";
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, conn);
                    sqlData.SelectCommand.Parameters.AddWithValue("@selectedMonth ", int.Parse(dtPicker.Value.Month.ToString()));
                    sqlData.SelectCommand.Parameters.AddWithValue("@selectedYear ", int.Parse(dtPicker.Value.Year.ToString()));
                    sqlData.SelectCommand.Parameters.AddWithValue("@selectedID ", inputProId);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);
                    conn.Close();
                    int Qty = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        Qty += int.Parse(dr[0].ToString());
                    }
                    return Qty;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        public double calculateMonthlyIncome(int inputProID,int Qty,DateTimePicker dtPicker)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sqlQuery = "SELECT Pro_Price FROM Product WHERE Pro_ID=@selectedID";
                    SqlDataAdapter sqlData = new SqlDataAdapter(sqlQuery, conn);
                    sqlData.SelectCommand.Parameters.AddWithValue("@selectedID", inputProID);
                    DataTable dt = new DataTable();
                    sqlData.Fill(dt);

                    string sqlQuery2 = "SELECT Purchased_Price,Quantity FROM Purchase WHERE Pro_ID=@selectedID AND Month(Date)=@selectedMonth AND Year(Date)=@selectedYear";
                    SqlDataAdapter sqlData2 = new SqlDataAdapter(sqlQuery2, conn);
                    sqlData2.SelectCommand.Parameters.AddWithValue("@selectedID", inputProID);
                    sqlData2.SelectCommand.Parameters.AddWithValue("@selectedMonth", int.Parse(dtPicker.Value.Month.ToString()));
                    sqlData2.SelectCommand.Parameters.AddWithValue("@selectedYear", int.Parse(dtPicker.Value.Year.ToString()));
                    DataTable dt2 = new DataTable();
                    sqlData2.Fill(dt2);
                    conn.Close();
                    double Sold_Price = Convert.ToDouble(dt.Rows[0]["Pro_Price"]);
                    double ΣPurchased_Price = 0.00;
                    int Σn = 0;
                    foreach (DataRow dr in dt2.Rows)
                    {
                        ΣPurchased_Price += Convert.ToDouble(double.Parse(dr[0].ToString()) * int.Parse(dr[1].ToString()));
                        Σn += int.Parse(dr[1].ToString());
                    }
                    double income = 0;
                    if (Σn != 0)
                    {
                        double Mean_Purchased_Price = ΣPurchased_Price / Σn;
                        double Unrounded_income = Qty * (Sold_Price - Mean_Purchased_Price);
                        income = Math.Round(Unrounded_income, 2);
                    }
                    return income;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }


        public void displaySales(DataTable dt,DataGridView dataGridView)
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
            dataGridView.DataSource = dt;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
        }
    }
}
