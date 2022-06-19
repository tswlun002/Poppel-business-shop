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
    public partial class ViewCart : Form
    {
        public bool ViewCartForm_closed = false;
        PopelsHome popelHome;
        ProductController productController;
        CustomerController customerController;
        Collection<Product> products;
        int customerNumber;
        //ListView Cart_listView
        public ViewCart(ProductController aController, CustomerController acustomerController)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            productController = aController;
            customerController = acustomerController;
            this.Load +=Cart_Load;
            this.FormClosed += Cart_Closed;
        }


        public void GetCustomerNumber(int customerNo)
        {
            customerNumber= customerNo;
        }
        public void setUpProductListView()
        {

            label1.Text = (customerToString(customerController.GetCustomer(customerNumber)).ToUpper() + "" + " CART ITEMS");

            ListViewItem productDetails;
            products = null;
            products = productController.AllCartProducts;
            Cart_listView.Clear();
            Cart_listView.Columns.Insert(0, "Product Id", 80, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(1, "Product Name", 90, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(2, "Size ", 60, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(3, "Price", 70, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(4, "Quantity", 90, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(5, "Description", 150, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(5, "Expire date", 80, HorizontalAlignment.Left);
            Cart_listView.Columns.Insert(6, "Total price", 100, HorizontalAlignment.Left);
            Console.WriteLine(""+customerNumber);

            foreach (Product product in products)
            {
                productDetails = new ListViewItem();
                productDetails.Text = product.ProductID.ToString();
                productDetails.SubItems.Add(product.ProductName);
                productDetails.SubItems.Add(product.ProductSize);
                productDetails.SubItems.Add(product.ProductPrice.ToString());
                productDetails.SubItems.Add(product.ProductQuantity.ToString());
                productDetails.SubItems.Add(product.ProductExpireDate.ToString());
                productDetails.SubItems.Add(product.ProductTotalPrice.ToString());
                productDetails.SubItems.Add(product.ProductDescription);
                Cart_listView.Items.Add(productDetails);
            }
            Cart_listView.Refresh();
            Cart_listView.GridLines = true;


        }
        private void Cart_Load(object sender, EventArgs e)
        {
            Cart_listView.Scrollable = true;
            popelHome = (PopelsHome)this.MdiParent;
            Cart_listView.View = View.Details;
            setUpProductListView();
        }

        private void Cart_Closed(object sender, FormClosedEventArgs e)
        {
            ViewCartForm_closed = true;
        }

        private void Cart_Activated(object sender, EventArgs e)
        {
            Cart_listView.Scrollable = true;
            Cart_listView.View = View.Details;
            setUpProductListView();
        }

        private void Cart_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cart_listView.Scrollable = true;
            Cart_listView.View = View.Details;
            setUpProductListView();
        }

        string customerToString(Customer cust)
        {
            return "" + cust;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
