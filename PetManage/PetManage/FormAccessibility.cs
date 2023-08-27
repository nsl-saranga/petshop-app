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
    public partial class FormAccessibilty : System.Windows.Forms.Form
    {
        public FormAccessibilty()
        {
            InitializeComponent();
        }
        private void FormAccessibilty_Load(object sender, EventArgs e)
        {
            Admin adminObj = new Admin();
            DataTable dt = adminObj.getAdmin();
            if (dt != null)
                adminObj.displayUser(dt, dataGridView1);

            Cashier cashierObj = new Cashier();
            DataTable dt2 = cashierObj.getCashier();
            if (dt2 != null)
                cashierObj.displayUser(dt2, dataGridView2);
        }
        private void OwnerIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.acceptOnlyNumbers(e);
        }
        private void OwnerIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.functionBackspace(e, OwnerIDTextBox);
        }
        private void CashierIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.acceptOnlyNumbers(e);
        }

        private void CashierIDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            NumberOnlyTextBox numberOnlyTextBox = new NumberOnlyTextBox();
            numberOnlyTextBox.functionBackspace(e, CashierIDTextBox);
        }

        private void OwnerAddBtn_Click(object sender, EventArgs e)
        {
            if (OwnerUnameTextBox.Text == "" || OwnerIDTextBox.Text == "" || OwnerPWTextBox.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int AdminID = int.Parse(OwnerIDTextBox.Text);
            string AdminUN = OwnerUnameTextBox.Text;
            string pw = OwnerPWTextBox.Text;
            Admin adminObj = new Admin();
            bool addResult = adminObj.addAdmin(AdminID, AdminUN, pw);
            if (addResult == true)
            {
                MessageBox.Show("An admin added succesfully");
                OwnerIDTextBox.Text = "";
                OwnerUnameTextBox.Text = "";
                OwnerPWTextBox.Text = "";
                DataTable dt = adminObj.getAdmin();
                if (dt != null)
                    adminObj.displayUser(dt, dataGridView1);
            }
        }
        private void OwnerEditBtn_Click_1(object sender, EventArgs e)
        {
            if (OwnerUnameTextBox.Text == "" || OwnerIDTextBox.Text == "" || OwnerPWTextBox.Text == "")
            {
                MessageBox.Show("Fill all the Textboxes before editing a row....");
                return;
            }
            int selectedRowInex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowInex];
            string SelectedID = selectedRow.Cells[0].Value.ToString();

            int AdminID = int.Parse(OwnerIDTextBox.Text);
            string AdminUN = OwnerUnameTextBox.Text;
            string pw = OwnerPWTextBox.Text;

            DialogResult result = MessageBox.Show("Are you sure, you want to edit the selected row", "ConfirmEdit.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Admin adminObj = new Admin();
                bool editResult = adminObj.editAdmin(AdminID, AdminUN, pw, int.Parse(SelectedID));
                if (editResult == true)
                {
                    MessageBox.Show("Successfully edited the selected row.");
                    OwnerIDTextBox.Text = "";
                    OwnerUnameTextBox.Text = "";
                    OwnerPWTextBox.Text = "";
                    DataTable dt = adminObj.getAdmin();
                    if (dt != null)
                        adminObj.displayUser(dt, dataGridView1);
                }
            }
        }
        private void OwnerRemoveBtn_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string SelectedID = selectedRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row.", "ConfirmDelete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Admin adminObj = new Admin();
                bool removeResult = adminObj.removeAdmin(int.Parse(SelectedID));
                if (removeResult)
                {
                    MessageBox.Show("Selected row has been deleted successfully");
                    DataTable dt = adminObj.getAdmin();
                    if (dt != null)
                        adminObj.displayUser(dt, dataGridView1);
                }
            }
        }

        private void CashierAddButton_Click_1(object sender, EventArgs e)
        {
            if (CashierUnameTextBox.Text == "" || CashierIDTextBox.Text == "" || CashierPWTextBox.Text == "" || CashierNameTextBox.Text == "" || CashierMobileTextBox.Text == "" || CashierGenderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required");
                return;
            }
            int CashierID = int.Parse(CashierIDTextBox.Text);
            string CashierUname = CashierUnameTextBox.Text;
            string CahsierPW = CashierPWTextBox.Text;
            string CashierName = CashierNameTextBox.Text;
            char CashierGender = Convert.ToChar(CashierGenderComboBox.SelectedItem);
            string CashierMobile = CashierMobileTextBox.Text;

            Cashier cashObj = new Cashier();
            bool addResult = cashObj.addCashier(CashierID, CashierUname, CahsierPW, CashierName, CashierGender, CashierMobile);
            if (addResult)
            {
                MessageBox.Show("A cashier added succesfully");
                CashierIDTextBox.Text = "";
                CashierUnameTextBox.Text = "";
                CashierPWTextBox.Text = "";
                CashierNameTextBox.Text = "";
                CashierGenderComboBox.SelectedIndex = -1;
                CashierMobileTextBox.Text = "";
                DataTable dt = cashObj.getCashier();
                if (dt != null)
                    cashObj.displayUser(dt, dataGridView2);
            }
        }
        private void CashierEditButton_Click_1(object sender, EventArgs e)
        {
            if (CashierUnameTextBox.Text == "" || CashierIDTextBox.Text == "" || CashierPWTextBox.Text == "" || CashierNameTextBox.Text == "" || CashierMobileTextBox.Text == "" || CashierGenderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Fill all the Textboxes before editing a row....");
                return;
            }
            int selectedRowInex = dataGridView2.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowInex];
            string SelectedCashierID = selectedRow.Cells[0].Value.ToString();

            int CashierID = int.Parse(CashierIDTextBox.Text);
            string CashierUname = CashierUnameTextBox.Text;
            string CahsierPW = CashierPWTextBox.Text;
            string CashierName = CashierNameTextBox.Text;
            char CashierGender = Convert.ToChar(CashierGenderComboBox.SelectedItem);
            string CashierMobile = CashierMobileTextBox.Text;

            DialogResult result = MessageBox.Show("Are you sure, you want to edit the selected row", "ConfirmEdit.", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Cashier cashObj = new Cashier();
                bool editResult = cashObj.editCashier(CashierID, CashierUname, CahsierPW, CashierName, CashierGender, CashierMobile, int.Parse(SelectedCashierID));
                if (editResult)
                {
                    MessageBox.Show("Successfully edited the selected row.");
                    CashierIDTextBox.Text = "";
                    CashierUnameTextBox.Text = "";
                    CashierPWTextBox.Text = "";
                    CashierNameTextBox.Text = "";
                    CashierGenderComboBox.SelectedIndex = -1;
                    CashierMobileTextBox.Text = "";
                    DataTable dt = cashObj.getCashier();
                    if (dt != null)
                        cashObj.displayUser(dt, dataGridView2);
                }
            }
        }
        private void CashierRemoveButton_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView2.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];
            string SelectedCashierID = selectedRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row.", "ConfirmDelete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Cashier cashObj = new Cashier();
                bool removeResult = cashObj.removeCashier(int.Parse(SelectedCashierID));
                if (removeResult)
                {
                    MessageBox.Show("Selected row has been deleted successfully");
                    DataTable dt = cashObj.getCashier();
                    if (dt != null)
                        cashObj.displayUser(dt, dataGridView2);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
