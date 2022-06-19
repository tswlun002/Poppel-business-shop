using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CustomerOrder_system.CustomerEntities;

namespace CustomerOrder_system.PresentationLayer
{
    public partial class PopelReport : Form
    {
        PopelsHome popelHome;
        public bool reportForm_closed = false;
        ProductController productController;
        Collection<Product> products ;

        public PopelReport(ProductController aController)
          
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            productController = aController;
            this.Load += PopelReport_Load;
            this.FormClosed += reportFormClosed;
        }
        private void PopelReport_Load(object sender, EventArgs e)
        {  

            popelHome = (PopelsHome)this.MdiParent;
            report_listView.View = View.Details;
            setUpProductListView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportFormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm_closed = true;
        }
        private void PopelReport_Activated(object sender, EventArgs e)
        {
            report_listView.Scrollable = true;
            report_listView.View = View.Details;
            setUpProductListView();
        }
       
        public void setUpProductListView()
         {
            ListViewItem productDetails;
             products= null;
            products = productController.AllProducts;
            report_listView.Clear();
            report_listView.Columns.Insert(0, "Product Id", 80, HorizontalAlignment.Left);
            report_listView.Columns.Insert(1, "Product Name", 90, HorizontalAlignment.Left);
            report_listView.Columns.Insert(2, "Size ", 60, HorizontalAlignment.Left);
            report_listView.Columns.Insert(3, "Price", 70, HorizontalAlignment.Left);
            report_listView.Columns.Insert(4, "Quantity", 90, HorizontalAlignment.Left);
            report_listView.Columns.Insert(5, "Description", 150, HorizontalAlignment.Left);
            report_listView.Columns.Insert(5, "Expire date", 80, HorizontalAlignment.Left);
            report_listView.Columns.Insert(6, "Total price", 100, HorizontalAlignment.Left);
            
            foreach (Product product in products)
            {
                int productdate = Convert.ToInt32(product.ProductExpireDate.ToString().Replace("-", "").Trim());
                int todayDate   = Convert.ToInt32(DateTime.Today.Date.ToString().Substring(0,10).Replace("/", "").Trim());
                if (productdate<=todayDate) {
                    //Console.WriteLine("lunga " + product.ProductID.ToString());
                    productDetails = new ListViewItem();
                    productDetails.Text = product.ProductID.ToString();
                    productDetails.SubItems.Add(product.ProductName);
                    productDetails.SubItems.Add(product.ProductSize);
                    productDetails.SubItems.Add(product.ProductPrice.ToString());
                    productDetails.SubItems.Add(product.ProductQuantity.ToString());
                    productDetails.SubItems.Add(product.ProductExpireDate.ToString());
                    productDetails.SubItems.Add(product.ProductTotalPrice.ToString());
                    productDetails.SubItems.Add(product.ProductDescription);
                    report_listView.Items.Add(productDetails);
                }
            }
            report_listView.Refresh();
            report_listView.GridLines = true;
        }

        
    }
}
