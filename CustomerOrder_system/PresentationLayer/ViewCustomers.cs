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
    public partial class ViewCustomers : Form
    {

        PopelsHome popelHome;
        public bool ViewCustomerForm_closed = false;
        CustomerController customerController;
        Collection<Customer> customers;
        
        public ViewCustomers( CustomerController aController)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            customerController = aController;
            this.Load += Customer_Load;
            this.FormClosed += Customer_Closed;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            popelHome = (PopelsHome)this.MdiParent;
            Customer_listView.View = View.Details;
            setUpCustomerListView();
        }

        private void Customer_Closed(object sender, FormClosedEventArgs e)
        {
            ViewCustomerForm_closed = true;
        }
        private void CustomerView_Activated(object sender, EventArgs e)
        {
            popelHome = (PopelsHome)this.MdiParent;
            Customer_listView.View = View.Details;
            setUpCustomerListView();
        }

        private void Customer_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void setUpCustomerListView() 
        {

            ListViewItem cutomerDetails;
            customers = null;
            customers = customerController.AllCustomers;
            Customer_listView.Clear();
            Customer_listView.Columns.Insert(0, "Customer Number", 50, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(1, " Name", 100, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(2, "Phone Number", 100, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(3, "Email", 100, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(4, "Address", 90, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(5, "Account Number", 150, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(5, "CC Number", 80, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(6, "CC Expire Date", 100, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(6, "Credit status", 100, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(6, "Credit Limit", 100, HorizontalAlignment.Left);
            Customer_listView.Columns.Insert(6, "Credit Limit", 100, HorizontalAlignment.Left);

            foreach (Customer acustomer in customers)
            {
                    cutomerDetails = new ListViewItem();
                    cutomerDetails.Text = acustomer.CustomerNumber.ToString();
                    cutomerDetails.SubItems.Add(acustomer.Name);
                    cutomerDetails.SubItems.Add(acustomer.CustomerTelephoneNumber);
                    cutomerDetails.SubItems.Add(acustomer.CustomerEmail);
                    cutomerDetails.SubItems.Add(acustomer.CustomerAddress);
                    cutomerDetails.SubItems.Add(acustomer.CustomerNumber.ToString());
                    cutomerDetails.SubItems.Add(acustomer.CCNumber.ToString());
                    cutomerDetails.SubItems.Add(acustomer.CCExpireDate);
                    cutomerDetails.SubItems.Add(acustomer.CreditStatus);
                    cutomerDetails.SubItems.Add(acustomer.CreditLimit.ToString());
                    cutomerDetails.SubItems.Add(acustomer.CurrentBalance.ToString());
                    Customer_listView.Items.Add(cutomerDetails);
            }
            Customer_listView.Refresh();
            Customer_listView.GridLines = true;
        }
    }
}
