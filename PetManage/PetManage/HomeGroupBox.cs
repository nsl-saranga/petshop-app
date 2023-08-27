using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetManage
{
    internal class HomeGroupBox
    {
        private GroupBox groupBox1 = new GroupBox();
        private GroupBox lowStockGroupBox= new GroupBox();

        public void SetGroupBox(string name,int Qty,double income)
        {
            
            groupBox1.Text = name;
            groupBox1.Size = new System.Drawing.Size(175, 122);
            groupBox1.Font = new Font("Arial", 10, FontStyle.Bold);
            groupBox1.BackColor = Color.FromArgb(65, 157, 120);
            groupBox1.ForeColor = Color.White;
            
            groupBox1.Padding = new Padding(10);
            Label label1= new Label();
            label1.Text = "Sold Qty : "+Qty;
            label1.Font = new Font("Arial", 10, FontStyle.Regular);
           
            Label label2 = new Label();
            label2.Text = "Income : Rs."+ income;
            label2.Font = new Font("Arial", 10, FontStyle.Regular);
            label2.Width = 160;
      
            label1.Location = new System.Drawing.Point(10,50);
            label2.Location = new System.Drawing.Point(10,75);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);

            
        }
        public GroupBox GetGroupBox()
        {
            return groupBox1;
        }

        public void SetLowStockGroupBox(string name, int StockQty)
        {
            lowStockGroupBox.Text = name;
            lowStockGroupBox.Size = new System.Drawing.Size(175, 122);
            lowStockGroupBox.Font = new Font("Arial", 10, FontStyle.Bold);
            lowStockGroupBox.BackColor = Color.FromArgb(65, 157, 120);
            lowStockGroupBox.ForeColor = Color.White;
            lowStockGroupBox.Padding = new Padding(10);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Properties.Resources.catFoot;
            pictureBox1.Location = new System.Drawing.Point(60, 40);

            Label label1 = new Label();
            label1.Text = "Stock Qty :" + StockQty;
            label1.Font = new Font("Arial", 10, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Width = 150;
            label1.Location = new System.Drawing.Point(2, 90);

            lowStockGroupBox.Controls.Add(pictureBox1);
            lowStockGroupBox.Controls.Add(label1);
        }
        public GroupBox GetLowStockGroupBox()
        {
            return lowStockGroupBox;
        }
    }
}
