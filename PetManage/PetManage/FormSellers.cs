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
    public partial class FormSellers : Form
    {
        public FormSellers()
        {
            InitializeComponent();
        }
        private void FormSellers_Load(object sender, EventArgs e)
        {
            Seller sellerObj = new Seller();
            DataTable dt = sellerObj.getSeller();
            if (dt != null)
                sellerObj.displaySeller(dt, SellerDataGridView);
        }
        private void SellerAddButton_Click(object sender, EventArgs e)
        {
            if (SellerNameTextBox.Text == "" || SellerIDTextBox.Text == "" || SellerTelTextBox.Text == "" || SellerEmailTextBox.Text == "" || SellerAddTextBox.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int SellerID = int.Parse(SellerIDTextBox.Text);
            string SellerName = SellerNameTextBox.Text;
            string Address = SellerAddTextBox.Text;
            string Email = SellerEmailTextBox.Text;
            string Phone = SellerTelTextBox.Text;

            Seller sellerObj = new Seller();
            bool addResult = sellerObj.addSeller(SellerID, SellerName, Address, Email, Phone);
            if (addResult)
            {
                MessageBox.Show("A Seller added succesfully");
                SellerIDTextBox.Text = "";
                SellerNameTextBox.Text = "";
                SellerAddTextBox.Text = "";
                SellerEmailTextBox.Text = "";
                SellerTelTextBox.Text = "";
                DataTable dt = sellerObj.getSeller();
                if (dt != null)
                    sellerObj.displaySeller(dt, SellerDataGridView);
            }
        }
        private void SellerEditButton_Click_1(object sender, EventArgs e)
        {
            if (SellerNameTextBox.Text == "" || SellerIDTextBox.Text == "" || SellerTelTextBox.Text == "" || SellerEmailTextBox.Text == "" || SellerAddTextBox.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int selectedRowInex = SellerDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = SellerDataGridView.Rows[selectedRowInex];
            string Seller_ID = selectedRow.Cells[0].Value.ToString();

            int SellerID = int.Parse(SellerIDTextBox.Text);
            string SellerName = SellerNameTextBox.Text;
            string Address = SellerAddTextBox.Text;
            string Email = SellerEmailTextBox.Text;
            string Phone = SellerTelTextBox.Text;
            DialogResult result = MessageBox.Show("Are you sure, you want to edit the selected row", "ConfirmEdit.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Seller sellerObj = new Seller();
                bool editResult = sellerObj.editSeller(SellerID, SellerName, Address, Email, Phone, int.Parse(Seller_ID));
                if (editResult)
                {
                    MessageBox.Show("Successfully edited the selected row.");
                    SellerIDTextBox.Text = "";
                    SellerNameTextBox.Text = "";
                    SellerAddTextBox.Text = "";
                    SellerEmailTextBox.Text = "";
                    SellerTelTextBox.Text = "";
                    DataTable dt = sellerObj.getSeller();
                    if (dt != null)
                        sellerObj.displaySeller(dt, SellerDataGridView);
                }
            }
        }
        private void SellerRemoveButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = SellerDataGridView.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = SellerDataGridView.Rows[selectedRowIndex];
            string SellerID = selectedRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row.", "ConfirmDelete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Seller sellerObj = new Seller();
                bool removeResult = sellerObj.removeSeller(int.Parse(SellerID));
                if (removeResult)
                {
                    MessageBox.Show("Selected row has been deleted successfully");
                    DataTable dt = sellerObj.getSeller();
                    if (dt != null)
                        sellerObj.displaySeller(dt, SellerDataGridView);
                }
            }
        }
    }
}
