using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CustomerOrder_system.CustomerEntities;

namespace CustomerOrder_system.PresentationLayer
{
    public partial class PopelsHome : Form
    {
        private int childFormNumber = 0;
        PopelReport popelReportForm;
        RegisterCustomer registerCustomerForm;
        CheckCustomer checkCustomerForm;
        ViewCustomers viewCustomerForm;
        ViewCart viewCartForm;
        EnterItemsInSystem EnterItemsToSystemForm;
        ProductController product;
        CustomerController customer;
        int customerNumber;
        public PopelsHome()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            product = new ProductController();
            customer = new CustomerController();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void CreateNewReportForm()
        {
            popelReportForm = new PopelReport(product);
            popelReportForm.MdiParent = this; 
            popelReportForm.StartPosition = FormStartPosition.CenterScreen;// write the code to set the start position (FormStartPosition) of the form to CenterParent

        }
        private void CreateNewCustomerForm()
        {
            registerCustomerForm = new RegisterCustomer(customer);
            registerCustomerForm.MdiParent = this; 
            registerCustomerForm.StartPosition = FormStartPosition.CenterScreen;
        }
        private  void CheckCustomerDetails()
        {
            checkCustomerForm = new CheckCustomer(customer);
            checkCustomerForm.MdiParent = this; 
            checkCustomerForm.StartPosition = FormStartPosition.CenterScreen;

        }
        private void ViewCustomerDetails()
        {
            viewCustomerForm = new ViewCustomers(customer); 
            viewCustomerForm.MdiParent = this; 
            viewCustomerForm.StartPosition = FormStartPosition.CenterScreen;

        }
        private void MakeOrderWindow()
        {
            EnterItemsToSystemForm = new EnterItemsInSystem(product,customer);
            EnterItemsToSystemForm.MdiParent = this;  
            EnterItemsToSystemForm.StartPosition = FormStartPosition.CenterScreen;

        }
        public void ViewCartWindow()
        {
            viewCartForm = new ViewCart(product,customer);
            viewCartForm.GetCustomerNumber(customerNumber);
            viewCartForm.MdiParent = this;  
            viewCartForm.StartPosition = FormStartPosition.CenterParent;

        }
        private void PopelsHome_Load(object sender, EventArgs e)
        {

        }

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cANCELITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTOFEXPIREDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (popelReportForm == null)
            {
                CreateNewReportForm();  }
            if (popelReportForm.reportForm_closed)
            // test if the form is closed
            {
                CreateNewReportForm();  }
            popelReportForm.Show();
        }

        private void aBOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (registerCustomerForm == null)
            {
                CreateNewCustomerForm(); 
            }
            if (registerCustomerForm.customerRegister_closed)
            // test if the form is closed
            {
                CreateNewCustomerForm();  
            }
            registerCustomerForm.Show();
            
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCustomerForm == null)
            {
                CheckCustomerDetails(); 
            }
            if (checkCustomerForm.CheckCustomerForm_closed)
            // test if the form is closed
            {
                CheckCustomerDetails();
            }
            checkCustomerForm.Show();
            
        }

        private void vIEWCUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (viewCustomerForm == null)
            {
                ViewCustomerDetails();    }
            if (viewCustomerForm.ViewCustomerForm_closed)
            // test if the form is closed
            {
                ViewCustomerDetails();     }
            viewCustomerForm.Show();
        }

        private void MakeOrder_Button_Click(object sender, EventArgs e)
        {
            if (EnterItemsToSystemForm == null)
            {
                MakeOrderWindow();  }
            if (EnterItemsToSystemForm.EnterItemForm_closed)
            // test if the form is closed
            {
                MakeOrderWindow();  }
            EnterItemsToSystemForm.Show();
        }
        public void ViewCartWindow(object sender, EventArgs e, int customerNo)
        {
            customerNumber = customerNo;
            if(viewCartForm == null)
            {
                ViewCartWindow();
            }
            if (viewCartForm.ViewCartForm_closed)
            {
                ViewCartWindow();
            }
            viewCartForm.Show();
        }
    }
}

