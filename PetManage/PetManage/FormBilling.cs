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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace PetManage {

    public partial class FormBilling : Form
    {
        public FormBilling()
        {
            InitializeComponent();
        }
        private void FormBilling_Load(object sender, EventArgs e)
        {
            Category catObj= new Category();
            DataTable returnedCategoryDt = catObj.getCategory();
            if(returnedCategoryDt!=null)
                catObj.displayCategory(returnedCategoryDt, DataGridView1);

            int selectedRowIndex = DataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = DataGridView1.Rows[selectedRowIndex];
            string Cat_ID = selectedRow.Cells[0].Value.ToString();
            Product proObj=new Product();
            DataTable returnedProductsDt= proObj.searchProductByCategory(int.Parse(Cat_ID));
            if(returnedProductsDt!=null)
            {
                proObj.displayProduct(returnedProductsDt, DataGridView2);
                DataGridView2.CurrentCell = null;
                numericUpDown1.Enabled = false;
            }
        }

        //this button is to display the products  of the selected category, in the dataGridView2.

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = DataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = DataGridView1.Rows[selectedRowIndex];
            string Cat_ID = selectedRow.Cells[0].Value.ToString();
            Product proObj = new Product();
            DataTable searchedDataTable = proObj.searchProductByCategory(int.Parse(Cat_ID));
            if (searchedDataTable != null)
            {
                proObj.displayProduct(searchedDataTable, DataGridView2);
                DataGridView2.CurrentCell = null;
                numericUpDown1.Enabled = false;
            }
        }
        //this is used to give maximum and minimum values to the numeric updown...
        private void DataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridView2.Rows.Count!=0)
            {
                int selectedRowIndex = DataGridView2.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = DataGridView2.Rows[selectedRowIndex];
                string Pro_ID = selectedRow.Cells[0].Value.ToString();
                Product proObj = new Product();
                DataTable searchedDataTable = proObj.searchProduct(int.Parse(Pro_ID));
                Bill billObj = new Bill();
                billObj.displayStockQty(searchedDataTable, numericUpDown1);
            }
        }
        //this button will display the selected products ,in the dataGridView3...
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Enabled == false)
            {
                MessageBox.Show("Sorry!.The selected product is currently unavailable.");
                return;
            }
            int selectedRowIndex = DataGridView2.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = DataGridView2.Rows[selectedRowIndex];
            string Pro_ID = selectedRow.Cells[0].Value.ToString();
            string date = dateTimePicker1.Value.ToString("d/M/yyyy");
            string time = dateTimePicker1.Value.ToString("h.mmtt");
            int Qty = int.Parse(numericUpDown1.Value.ToString());
            DialogResult result = MessageBox.Show("Are you sure, you want add the selected item to the bill.", "ConfirmBill.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Product proObj = new Product();
                DataTable searchedDataTable = proObj.searchProduct(int.Parse(Pro_ID));
                if (searchedDataTable != null)
                {
                    Bill billObj = new Bill();
                    billObj.addToBill(searchedDataTable, Qty, date, time, dataGridView3);
                }
            }
        }
        private void printBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, you want to print the bill.", "ConfirmBill.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Sales salesObj = new Sales();
                bool recordResult = salesObj.recordSales(dataGridView3);
                if (recordResult)
                {
                    foreach(DataGridViewRow row in dataGridView3.Rows)
                    {
                        Product proObj = new Product();
                        bool updateResult = proObj.decreaseStockQty(Convert.ToInt32(row.Cells[0].Value), Convert.ToInt32(row.Cells[2].Value));
                        if (!updateResult)
                            throw new Exception("Failed to update stock quantity.");
                    }
                    if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        printDocument1.Print();
                    dataGridView3.Rows.Clear();
                    
                }
            }
        }
        //this will clear the data in the dataGridView3.
        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
        }
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bill billObj = new Bill();
            billObj.printBill(dateTimePicker1.Value.ToString("d/M/yyyy"), e, dataGridView3);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            this.Hide();

            Login loginForm = new Login();

            loginForm.Show();
        }
    }
 }
