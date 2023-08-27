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
    public partial class FormPurchase : Form
    {
        public FormPurchase()
        {
            InitializeComponent();
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            Purchase purObj = new Purchase();
            DataTable dt = purObj.getPurchase();
            if (dt != null)
                purObj.displayPurchase(dt, PurDataGridView);
        }

        private void PurAddButton_Click(object sender, EventArgs e)
        {
            if (purchaseIDTextBox.Text == "" || SellerIDTextBox.Text == "" || ProIDTextBox.Text == "" || QtyTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int PurchaseID = int.Parse(purchaseIDTextBox.Text);
            int ProductID = int.Parse(ProIDTextBox.Text);
            int SellerID = int.Parse(SellerIDTextBox.Text);
            string Date = dateTimePicker1.Value.ToString("d/M/yyyy");
            int Qty = int.Parse(QtyTextBox.Text);
            double Price = double.Parse(PriceTextBox.Text);

            Purchase purObj=new Purchase();
            bool addResult = purObj.addPurchase(PurchaseID, ProductID, SellerID, Date, Qty, Price);
            if(addResult)
            {
                Product proObj=new Product();
                bool updateResult=proObj.increaseStockQty(ProductID, Qty);
                if(updateResult)
                {
                    MessageBox.Show("Successfully added a new Purchase record.");
                    purchaseIDTextBox.Text = "";
                    ProIDTextBox.Text = "";
                    SellerIDTextBox.Text = "";
                    PriceTextBox.Text = "";
                    QtyTextBox.Text = "";
                    DataTable dt=purObj.getPurchase();
                    if (dt != null)
                        purObj.displayPurchase(dt, PurDataGridView);
                }
            }    
        }

        private void PurEditButton_Click(object sender, EventArgs e)
        {
            if (purchaseIDTextBox.Text == "" || SellerIDTextBox.Text == "" || ProIDTextBox.Text == "" || QtyTextBox.Text == "" || PriceTextBox.Text == "")
            {
                MessageBox.Show("Fill all the Textboxes before editing a row....");
                return;
            }
            
            int selectedRowInex = PurDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = PurDataGridView.Rows[selectedRowInex];
            string Pur_ID = selectedRow.Cells[0].Value.ToString();
            string ProID = selectedRow.Cells[1].Value.ToString();
            int existingQty = int.Parse(selectedRow.Cells[4].Value.ToString());

            int PurchaseID = int.Parse(purchaseIDTextBox.Text);
            int ProductID = int.Parse(ProIDTextBox.Text);
            int SellerID = int.Parse(SellerIDTextBox.Text);
            string Date = dateTimePicker1.Value.ToString("d/M/yyyy");
            int Qty = int.Parse(QtyTextBox.Text);
            double Price = double.Parse(PriceTextBox.Text);

            DialogResult result = MessageBox.Show("Are you sure, you want to edit the selecred row", "ConfirmEdit.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Purchase purObj = new Purchase();
                bool returnedVal = purObj.editPurchase(PurchaseID, ProductID, SellerID, Date, Qty, Price, int.Parse(Pur_ID));
                if (returnedVal)
                {
                    continueUpdateStock();
                }
                
            }
            void continueUpdateStock()
            {
                if(ProductID!=int.Parse(ProID))//if the edit product ID is not equal to the Product ID in the selected record.
                {
                    Product proObj = new Product();
                    bool updatedRes = proObj.increaseStockQty(ProductID, Qty);
                    if (!updatedRes)
                        throw new Exception("Failed to update stock quantity.");
                }
                else//if the edit product ID is nequal to the Product ID in the selected record.
                {
                    if (existingQty != int.Parse(QtyTextBox.Text))//if the existing qty is not equal to the quantity in the textbox.
                    {
                        if (existingQty > int.Parse(QtyTextBox.Text))
                        {
                            int updatedQty = existingQty - int.Parse(QtyTextBox.Text);
                            Product proObj = new Product();
                            bool updatedRes = proObj.decreaseStockQty(int.Parse(ProID), updatedQty);
                            if (!updatedRes)
                                throw new Exception("Failed to update stock quantity.");
                        }
                        else
                        {
                            int updatedQty = int.Parse(QtyTextBox.Text) - existingQty;
                            Product proObj = new Product();
                            bool updatedRes = proObj.increaseStockQty(int.Parse(ProID), updatedQty);
                            if (!updatedRes)
                                throw new Exception("Failed to update stock quantity.");
                        }
                    }
                }
             
                MessageBox.Show("Successfully edited the selected row.");
                purchaseIDTextBox.Text = "";
                ProIDTextBox.Text = "";
                SellerIDTextBox.Text = "";
                PriceTextBox.Text = "";
                QtyTextBox.Text = "";
                Purchase purObj = new Purchase();
                DataTable dt = purObj.getPurchase();
                if (dt != null)
                    purObj.displayPurchase(dt, PurDataGridView);
            }
        }
        private void PurRemoveButton_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = PurDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = PurDataGridView.Rows[selectedRowIndex];
            string ProID = selectedRow.Cells[1].Value.ToString();
            string PurID = selectedRow.Cells[0].Value.ToString();
            string Qty = selectedRow.Cells[4].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row.", "ConfirmDelete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Purchase purObj = new Purchase();
                bool removeResult = purObj.removePurchase(int.Parse(PurID));
                if (removeResult)
                {
                    Product proObj = new Product();
                    bool updatedResult = proObj.decreaseStockQty(int.Parse(ProID), int.Parse(Qty));
                    if (updatedResult)
                    {
                        MessageBox.Show("Successfully removed the selected row.");
                        DataTable dt = purObj.getPurchase();
                        if (dt != null)
                            purObj.displayPurchase(dt, PurDataGridView);
                    }
                }

            }
        }
    }
}
