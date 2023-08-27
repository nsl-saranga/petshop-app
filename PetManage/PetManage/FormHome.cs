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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PetManage
{
    public partial class FormHome : Form
    {
        
        public FormHome()
        {
            InitializeComponent();
           
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            SalesGoBtn_Click(sender, e);

            Product proObj = new Product();
            DataTable dt = proObj.getProduct();
            if (dt != null)
            {
                List<System.Windows.Forms.GroupBox> HomeGroupBoxList = new List<System.Windows.Forms.GroupBox>();
                foreach (DataRow dr in dt.Rows)
                {
                    if (int.Parse(dr[2].ToString()) <= 10)
                    {
                        string pro_Name = dr[1].ToString();
                        int lowStockQty = int.Parse(dr[2].ToString());
                        HomeGroupBox homeGroupBox = new HomeGroupBox();
                        homeGroupBox.SetLowStockGroupBox(pro_Name, lowStockQty);
                        HomeGroupBoxList.Add(homeGroupBox.GetLowStockGroupBox());
                    }

                    panel2.Controls.Clear();
                    panel2.Padding = new Padding(10);
                    int X = 10;
                    int Y = 35;
                    foreach (System.Windows.Forms.GroupBox ele in HomeGroupBoxList)
                    {
                        panel2.Controls.Add(ele);
                        ele.Location = new Point(X, Y);
                        X = X + 190;
                    }
                }
            }
        }

        private void SalesGoBtn_Click(object sender, EventArgs e)
        {
            Product proObj=new Product();
            DataTable dt = proObj.getProduct();
            if(dt!=null)
            {
                List<System.Windows.Forms.GroupBox> HomeGroupBoxList = new List<System.Windows.Forms.GroupBox>();
                foreach (DataRow dr in dt.Rows)
                {
                    string pro_Name = dr[1].ToString();
                    int pro_ID = int.Parse(dr[0].ToString());
                    Sales salesObj = new Sales();
                    int returnedSoldQty = salesObj.calculateMonthlySoldQty(pro_ID,dateTimePicker2);
                    if(returnedSoldQty != -1)
                    {
                        double income = salesObj.calculateMonthlyIncome(pro_ID,returnedSoldQty,dateTimePicker2);
                        if(income!= -1)
                        {
                            HomeGroupBox homeGroupBox = new HomeGroupBox();
                            homeGroupBox.SetGroupBox(pro_Name, returnedSoldQty, income);
                            HomeGroupBoxList.Add(homeGroupBox.GetGroupBox());
                        }
                    }
                }
                panel1.Controls.Clear();
                panel1.Padding=new Padding(10);
                int X = 10;
                int Y = 35;
                foreach (System.Windows.Forms.GroupBox ele in HomeGroupBoxList)
                {
                  
                    panel1.Controls.Add(ele);
                    ele.Location = new Point(X, Y);
                    X = X + 190;
                }
            }
        }

        private void sideBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
 