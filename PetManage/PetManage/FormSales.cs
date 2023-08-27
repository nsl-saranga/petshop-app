using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for the database......
using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace PetManage
{
    public partial class FormSales : System.Windows.Forms.Form
    {
        public FormSales()
        {
            InitializeComponent();
        }
        private void FormSales_Load(object sender, EventArgs e)
        {
            Sales salesObj=new Sales();
            DataTable returnedSalesDt=salesObj.getAllSales();
            if (returnedSalesDt != null)
                salesObj.displaySales(returnedSalesDt, dataGridView1);
            dateTimePicker1.Enabled= false;
            dateTimePicker2.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dateTimePicker1.Enabled = true;
                    dateTimePicker2.Enabled = false;
                    break;
                case 1:
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = true;
                    break;

                default:
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    return;
            }
        }
        private void SalesGoBtn_Click(object sender, EventArgs e)
        {
            Sales salesObj = new Sales();
            if (comboBox1.SelectedIndex == 0)
            {
                DataTable returnedSalesDT = salesObj.getDailySales(proIDTextBox, dateTimePicker1);
                if (returnedSalesDT != null)
                    salesObj.displaySales(returnedSalesDT, dataGridView1);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                DataTable returnedSalesDT = salesObj.getMonthlySales(proIDTextBox, dateTimePicker2);
                if (returnedSalesDT != null)
                    salesObj.displaySales(returnedSalesDT, dataGridView1);
            }
            else
            {
                MessageBox.Show("Select sort method");
                return;
            }
            double Tot = 0.00;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Tot += Convert.ToDouble(row.Cells[3].Value);
            }
            if (comboBox1.SelectedIndex == 0)
                ShowRevTxtBox.Text = "Daily Total Revenue for " + dateTimePicker1.Value.ToShortDateString() + " is : Rs." + Tot;
            else if (comboBox1.SelectedIndex == 1)
                ShowRevTxtBox.Text = "Monthly Total Revenue for " + dateTimePicker2.Value.ToString("M/yyyy") + " is : Rs." + Tot;
        }
    }           
}

