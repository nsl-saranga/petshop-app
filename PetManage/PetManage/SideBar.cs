using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PetManage
{

    public partial class SideBar : UserControl
    {
        public SideBar()
        {
            InitializeComponent();
        }
        

        private void HomeBtn_Click(object sender, EventArgs e)
        {
          
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            this.FindForm().Hide();
            FormHome homeForm = new FormHome();
            for (double i = 0.5; i <= 1; i += 0.1)
            {
                homeForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
           
            homeForm.Show();
          
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
           
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }

            this.FindForm().Hide();
            FormProductCategory catForm = new FormProductCategory();


            for (double i = 0.5; i <= 1; i += 0.1)
            {
                catForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            catForm.Show();

            
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }

            this.FindForm().Hide();
            FormProduct proForm = new FormProduct();


            for (double i = 0.5; i <= 1; i += 0.1)
            {
                proForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            proForm.Show();
            
        }

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            this.FindForm().Hide();
            FormPurchase purchaseForm = new FormPurchase();
            for (double i = 0.5; i <= 1; i += 0.1)
            {
                purchaseForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            purchaseForm.Show();
           
        }

        private void SellerBtn_Click(object sender, EventArgs e)
        {
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }

            this.FindForm().Hide();
            FormSellers sellerForm = new FormSellers();


            for (double i = 0.5; i <= 1; i += 0.1)
            {
                sellerForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            sellerForm.Show();
        
        }

        private void AccessBtn_Click(object sender, EventArgs e)
        {


            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }

            this.FindForm().Hide();
            FormAccessibilty accessForm = new FormAccessibilty();


            for (double i = 0.5; i <= 1; i += 0.1)
            {
                accessForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            accessForm.Show();

            
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            for (double i = 1; i >= 0; i -= 0.1)
            {
                this.FindForm().Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }

            this.FindForm().Hide();
            FormSales salesForm = new FormSales();


            for (double i = 0.5; i <= 1; i += 0.1)
            {
                salesForm.Opacity = i;
                System.Threading.Thread.Sleep(5);
                Application.DoEvents();
            }
            salesForm.Show();
           
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

            this.FindForm().Hide();

            Login loginForm = new Login();
            
            loginForm.Show();
           
        }

    }
}
