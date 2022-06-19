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
    public partial class CheckCustomer : Form
    {
        public bool CheckCustomerForm_closed =  false;
        Customer customer;
        CustomerController controller;
        Collection<Customer> customers;
        public CheckCustomer( CustomerController acontroller)
        {
            InitializeComponent();
            customer = new Customer();
            controller= acontroller;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            customer.CustomerNumber = Convert.ToInt32(CustomerNumbertextBox.Text);

            VerifyCustomer(customer.CustomerNumber);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void VerifyCustomer(int customerNo)
        {
            bool registereCustomer = false;
            customers = null;
            customers = controller.AllCustomers;

            foreach(Customer aCustomer in customers)
            {
                Console.WriteLine("izile apha = "+ aCustomer.CustomerNumber);
                if(aCustomer.CustomerNumber == customerNo && aCustomer.CreditStatus =="Good")
                {
                    MessageBox.Show("VERIFIED!!", "This is " + aCustomer.Name +" Credit Status: " +aCustomer.CreditStatus);
                    registereCustomer = true;
                    break;
                }
                else if (aCustomer.CustomerNumber == customerNo && aCustomer.CreditStatus != "Good")
                {
                    MessageBox.Show("Registered!!", "This is " + aCustomer.Name + " Credit Status: " + aCustomer.CreditStatus);
                    registereCustomer = true;
                    break;
                }

            }
            if (registereCustomer == false)
            {
                MessageBox.Show("Please Register the customer", "NOT REGISTERED");
            }
        }

        private void CheckCustomer_Load(object sender, EventArgs e)
        {
           // VerifyCustomer();

        }

        private void CheckCustomer_Closed(object sender, FormClosedEventArgs e)
        {
            CheckCustomerForm_closed = true;
        }

        private void CheckCustomer_Activated(object sender, EventArgs e)
        {
           // VerifyCustomer();
        }
    }
}
