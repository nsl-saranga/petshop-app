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
using System.Net.NetworkInformation;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace PetManage
{

    public partial class FormProductCategory : System.Windows.Forms.Form
    {
        public FormProductCategory()
        {
            InitializeComponent();
        }

        private void FormProductCategory_Load(object sender, EventArgs e)
        {
            Category catObj=new Category();
            DataTable dt = catObj.getCategory();
            if (dt == null)
                return;
            else
                catObj.displayCategory(dt,dataGridView1);

        }

        
        //**************************************************************************************************//
        private void proCategoryIDTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            NumberOnlyTextBox textBox = new NumberOnlyTextBox();
            textBox.functionBackspace(e, proCategoryIDTextBox);
        }

        private void proCategoryIDTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            NumberOnlyTextBox textBox = new NumberOnlyTextBox();
            textBox.acceptOnlyNumbers(e);
        }
        //**************************************************************************************************//

        
       
        private void categoryAddButtpn_Click(object sender, EventArgs e)
        {
            
            if (proCategoryIDTextBox.Text==""|| proCategoryNameTextBox.Text == "" || proCategoryDescriptionTextBox.Text == "")
            {
                MessageBox.Show("All fields are essential");
                return;
            }
            int Category_ID = int.Parse(proCategoryIDTextBox.Text);
            string Category_Name = proCategoryNameTextBox.Text;
            string Category_Des = proCategoryDescriptionTextBox.Text;
            Category catObj = new Category();
            bool AddResult=catObj.addCategory(Category_ID, Category_Name, Category_Des);
            if(AddResult==true)
            {
                MessageBox.Show("A category added succesfully");
                proCategoryDescriptionTextBox.Text = "";
                proCategoryNameTextBox.Text = "";
                proCategoryIDTextBox.Text = "";
                DataTable dt=catObj.getCategory();
                if (dt != null)
                {
                    catObj.displayCategory(dt, dataGridView1);
                }       
            }
        }

        private void categoryEditButton_Clicked(object sender, EventArgs e)
        {
            if(proCategoryNameTextBox.Text==""|| proCategoryDescriptionTextBox.Text ==""||proCategoryIDTextBox.Text=="")
            {
                MessageBox.Show("Fill the boxes that you need to edit....");
                return;
            }
            int selectedRowInex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowInex];
            string Selected_Cat_ID = selectedRow.Cells[0].Value.ToString();
            int Category_ID = int.Parse(proCategoryIDTextBox.Text);
            string Category_Name = proCategoryNameTextBox.Text;
            string Category_Des = proCategoryDescriptionTextBox.Text;
            DialogResult result = MessageBox.Show("Are you sure, you want to edit the selected row", "ConfirmEdit.", MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                Category catObj = new Category();
                bool EditResult=catObj.editCategory(Category_ID, Category_Name, Category_Des, int.Parse(Selected_Cat_ID));
                if(EditResult == true)
                {
                    MessageBox.Show("A category has been edited succesfully");
                    proCategoryDescriptionTextBox.Text = "";
                    proCategoryNameTextBox.Text = "";
                    proCategoryIDTextBox.Text = "";
                    DataTable dt = catObj.getCategory();
                    if (dt != null)
                        catObj.displayCategory(dt,dataGridView1);
                }
            }
        }
        private void categoryRemoveButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
            string Selected_catID = selectedRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row.", "ConfirmDelete", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Category catObj = new Category();
                bool RemoveResult = catObj.removeCategory(int.Parse(Selected_catID));
                if(RemoveResult == true)
                {
                    MessageBox.Show("A category has been deleted succesfully");
                    DataTable dt = catObj.getCategory();
                    if (dt == null)
                        return;
                    else
                        catObj.displayCategory(dt,dataGridView1);
                }
            }

        }      
    }
}
       