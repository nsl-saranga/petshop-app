using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PetManage
{
    internal class Bill
    {
        private int ProductID;
        private string ProductName;
        private int PurchasingQty;
        private double Price;
        private double Total;
        private string Date;
        private string Time;

        public void displayStockQty(DataTable dt,NumericUpDown numericUpDown)
        {
            int Qty = Convert.ToInt32(dt.Rows[0][2]);
            numericUpDown.Enabled = false;
            if (Qty>0)
            {
                numericUpDown.Enabled = true;
                numericUpDown.Maximum = Qty;
                numericUpDown.Minimum = 1;
            } 
        }
        public void addToBill(DataTable dt,int Qty,string date,string time, DataGridView dataGridView)
        {
            ProductID = Convert.ToInt32(dt.Rows[0][0]);
            ProductName = (dt.Rows[0][1]).ToString();
            PurchasingQty = Qty;
            Price = double.Parse(dt.Rows[0][3].ToString());
            Total = Convert.ToDouble(PurchasingQty * Price);
            Date = date;
            Time = time;

            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            dataGridView.Rows.Add(ProductID, ProductName, PurchasingQty, Price, Total, Date, Time);
        }
        public void printBill(string Date, System.Drawing.Printing.PrintPageEventArgs e,DataGridView dataGridView)
        {
        
            double TotalPrice = 0.00;
            int valY = 310;

            SolidBrush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawString("CASH RECEIPT", new Font("Arial", 25, FontStyle.Bold), brush, new PointF(270, 50));
            e.Graphics.DrawString("Shop : Paws and Claws Pet Shop", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(180, 110));
            e.Graphics.DrawString("Address : 151/3, Kurana, Negombo", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(180, 150));
            e.Graphics.DrawString("******************************************************************", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, 190));
            e.Graphics.DrawString("Date  : " + Date, new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, 230));
            e.Graphics.DrawString("Item", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, 270));
            e.Graphics.DrawString("Qty", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(380, 270));
            e.Graphics.DrawString("Price(Rs.)", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(480, 270));
            e.Graphics.DrawString("Total", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(680, 270));
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                e.Graphics.DrawString(row.Cells[1].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, valY));
                e.Graphics.DrawString(row.Cells[2].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), brush, new PointF(380, valY));
                e.Graphics.DrawString(row.Cells[3].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), brush, new PointF(480, valY));
                e.Graphics.DrawString(row.Cells[4].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), brush, new PointF(680, valY));
                valY += 40;
                TotalPrice += Convert.ToDouble(Convert.ToDouble(row.Cells[4].Value));
            }
            e.Graphics.DrawString("******************************************************************", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, valY));
            valY += 40;
            e.Graphics.DrawString("Total Price(Rs.)    :", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, valY));

            e.Graphics.DrawString(TotalPrice.ToString(), new Font("Arial", 20, FontStyle.Bold), brush, new PointF(680, valY));
            valY += 40;
            e.Graphics.DrawString("******************************************************************", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, valY));
            valY += 40;
            e.Graphics.DrawString("******************************************************************", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(60, valY));
            valY += 40;
            e.Graphics.DrawString("Thank You.", new Font("Arial", 20, FontStyle.Bold), brush, new PointF(320, valY));
        }

    }

}
