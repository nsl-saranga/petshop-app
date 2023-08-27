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

namespace PetManage
{
    public partial class FormProduct : System.Windows.Forms.Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
      
        private void FormProduct_Load(object sender, EventArgs e)
        {
            Product proObj = new Product();
            DataTable dt = proObj.getProduct();
            if (dt != null)
                proObj.displayProduct(dt, productDataGridView);
        }

        //********************************************************************************************************
        private void ProIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.acceptOnlyNumbers(e);
        }
        private void ProIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.functionBackspace(e,ProIDTextBox);
        }
        private void ProQtyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.acceptOnlyNumbers(e);
        }
        private void ProQtyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.functionBackspace(e, ProQtyTextBox);
        }
        private void ProCat_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.acceptOnlyNumbers(e);
        }
        private void ProCat_IDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.functionBackspace(e, ProCat_IDTextBox);
        }

        //********************************************************************************************************

        private void ProAddButton_Click(object sender, EventArgs e)
        {
            if (ProNameTextBox.Text == "" || ProIDTextBox.Text == "" || ProPriceTextBox.Text == "" || ProQtyTextBox.Text == "" || ProCat_IDTextBox.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int Product_ID = int.Parse(ProIDTextBox.Text);
            string Product_Name = ProNameTextBox.Text;
            int Stock_Qty = int.Parse(ProQtyTextBox.Text);
            double Price = double.Parse(ProPriceTextBox.Text);
            int Category_ID = int.Parse(ProCat_IDTextBox.Text);

            Product proObj = new Product();
            bool AddResult = proObj.addProduct(Product_ID, Product_Name, Stock_Qty, Price, Category_ID);
            if (AddResult == true)
            {
                MessageBox.Show("A product added succesfully");
                ProIDTextBox.Text = "";
                ProNameTextBox.Text = "";
                ProQtyTextBox.Text = "";
                ProPriceTextBox.Text = "";
                ProCat_IDTextBox.Text = "";
                DataTable dt = proObj.getProduct();
                if (dt != null)
                {
                    proObj.displayProduct(dt, productDataGridView);
                }
            }
        }
        private void ProEditButton_Click_1(object sender, EventArgs e)
        {
            if (ProNameTextBox.Text == "" || ProIDTextBox.Text == "" || ProPriceTextBox.Text == "" || ProQtyTextBox.Text == "" || ProCat_IDTextBox.Text == "")
            {
                MessageBox.Show("Fill all the Textboxes before editing a row....");
                return;
            }
            int selectedRowInex = productDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = productDataGridView.Rows[selectedRowInex];
            string Selected_ProID = selectedRow.Cells[0].Value.ToString();

            int Product_ID = int.Parse(ProIDTextBox.Text);
            string Product_Name = ProNameTextBox.Text;
            int Stock_Qty = int.Parse(ProQtyTextBox.Text);
            double Price = double.Parse(ProPriceTextBox.Text);
            int Category_ID = int.Parse(ProCat_IDTextBox.Text);

            DialogResult result = MessageBox.Show("Are you sure, you want to edit the selected row", "ConfirmEdit.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Product proObj = new Product();
                bool EditResult = proObj.editProduct(Product_ID, Product_Name, Stock_Qty, Price, Category_ID, int.Parse(Selected_ProID));
                if (EditResult == true)
                {
                    MessageBox.Show("A Product has been edited succesfully");
                    ProIDTextBox.Text = "";
                    ProNameTextBox.Text = "";
                    ProQtyTextBox.Text = "";
                    ProPriceTextBox.Text = "";
                    ProCat_IDTextBox.Text = "";
                    DataTable dt = proObj.getProduct();
                    if (dt != null)
                        proObj.displayProduct(dt, productDataGridView);
                }
            }
        }

        private void ProRemoveButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = productDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = productDataGridView.Rows[selectedRowIndex];
            string Selected_ProID = selectedRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row.", "ConfirmDelete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Product proObj = new Product();
                bool removeResult = proObj.removeProduct(int.Parse(Selected_ProID));
                if (removeResult == true)
                {
                    MessageBox.Show("Selected row has been deleted successfully");
                    DataTable dt = proObj.getProduct();
                    if (dt != null)
                        proObj.displayProduct(dt, productDataGridView);
                }
            }
        }
    }
}
