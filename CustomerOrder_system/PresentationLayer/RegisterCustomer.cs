using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerOrder_system.CustomerEntities;

namespace CustomerOrder_system.PresentationLayer
{
    public partial class RegisterCustomer : Form
    {
        PopelsHome popelHome;
        public bool customerRegister_closed = false;
        CustomerController customerController;
        Customer aCustomer = new Customer();
        public RegisterCustomer( CustomerController aController)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            customerController = aController;
            this.Load += CustomerRegisterForm_Load;
            this.FormClosed += CustomerRegisterForm_closed;
        }

        public Customer PopulateCustomer()
        {
            aCustomer.CustomerNumber = new Random().Next(100,1000);
            aCustomer.Name = fullname_textBox.Text;
            aCustomer.CustomerTelephoneNumber = phoneNumber_textBox.Text;
            aCustomer.CustomerEmail = EmailAddress_textBox.Text;
            aCustomer.AccountnUmber = Convert.ToInt32(accountNumber_textBox2.Text);
            aCustomer.CCNumber      = Convert.ToInt32(ccNumber_textBox.Text);
            aCustomer.CCExpireDate = ccExpireDate_textBox.Text;
            aCustomer.CreditStatus = "Waitting for Credit Verification";
            aCustomer.CreditLimit = 0;
            aCustomer.CurrentBalance = 0;

            return aCustomer;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRegisterForm_closed(object sender, FormClosedEventArgs e)
        {
            customerRegister_closed = true;
        }

        private void CustomerRegisterForm_Load(object sender, EventArgs e)
        {
        }

        private void CustomerRegisterForm_Activated(object sender, EventArgs e)
        {

        }

        private void RegisterNext_button_Click(object sender, EventArgs e)
        {
            Customer obj = PopulateCustomer();
            customerController.AddCustomer(obj);
            fullname_textBox.Clear();
            phoneNumber_textBox.Clear();
            EmailAddress_textBox.Clear();
            address_richTextBox1.Clear();
            accountNumber_textBox2.Clear();
            ccNumber_textBox.Clear();
            ccExpireDate_textBox.Clear();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }

        private void ccExpireDate_textBox_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled =true;
        }

        private void ccNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }

        private void accountNumber_textBox2_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }

        private void address_richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }

        private void phoneNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }

        private void fullname_textBox_TextChanged(object sender, EventArgs e)
        {
            RegisterNext_button.Enabled = false;
        }
    }
}
