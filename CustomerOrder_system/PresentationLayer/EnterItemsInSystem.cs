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
    public partial class EnterItemsInSystem : Form
    {
        PopelsHome popelHome;
        bool available;
        public bool EnterItemForm_closed = false;
        ProductController productController;
        CustomerController customer;
        Collection<Customer> customers;
        Collection<Product> products;
        Product aproduct = new Product();
        Customer acustomer = new Customer();
        int custNumber;
        public EnterItemsInSystem(ProductController aController, CustomerController acustomer)
        {
            InitializeComponent();
            productController = aController;
            customer = acustomer;
        }

        public void CartItem()
        {
            try
            {
                aproduct.ProductName = Name_textBox.Text;
                aproduct.ProductSize = Size_textBox.Text;
                aproduct.ProductQuantity = Convert.ToInt32(Quantity_textBox.Text.Trim());
                acustomer.CustomerNumber = Convert.ToInt32(CustomerNumber_textBox.Text.Trim());
                custNumber = Convert.ToInt32(CustomerNumber_textBox.Text.Trim());
                CheckItemAvailability(Name_textBox.Text, Size_textBox.Text, Convert.ToInt32(Quantity_textBox.Text.Trim()));
            }catch(Exception ex)
            {
                MessageBox.Show("Enter Correct Format(numbers only) in Customer number and Quantity textBox ");
            }
        }
       
        public Customer CartCustomer()
        {

            return null;
        }

        public void CheckItemAvailability(string name, string size, int qty)
        {
            available = false;
            products = null;
            products = productController.AllProducts;
            foreach (Product product in products)
            {
                Console.WriteLine(" Inventory item: "+product.ProductName);
                if (product.ProductName.Trim().ToLower() == name.Trim().ToLower() & product.ProductSize.ToLower().Trim().Equals(size.ToLower().Trim()) &
                    product.ProductQuantity>= qty)
                {
                    available = true;
                    MessageBox.Show("Item Added to Cart");
                    aproduct.ProductID = new Random().Next(1, 5000);
                    aproduct.ProductName = name;
                    aproduct.ProductSize = size;
                    aproduct.ProductPrice = product.ProductPrice;
                    aproduct.ProductQuantity = qty;
                    aproduct.ProductTotalPrice = aproduct.ProductTotalPrice + qty * aproduct.ProductPrice;
                    aproduct.ProductExpireDate = product.ProductExpireDate;
                    aproduct.ProductDescription = product.ProductDescription;
                    aproduct = product;
                    addedIterm(aproduct);
                    break;
                }
                else if(product.ProductName == aproduct.ProductName & product.ProductSize.ToLower().Trim().Equals(aproduct.ProductSize.ToLower().Trim()) &
                    product.ProductQuantity >= aproduct.ProductQuantity & product.ProductPrice * aproduct.ProductQuantity > CustomerLimit(acustomer.CustomerNumber))
                     {
                        //available= false;
                         MessageBox.Show(" Total Price Exceeds Customer CreditLimit");
                        Name_textBox.Clear();
                        Size_textBox.Clear();
                        CustomerNumber_textBox.Clear();
                        Quantity_textBox.Clear();
                }
                 else
                 {
                    available = false;

                 }
            }
            if(available == false)
            {
                MessageBox.Show("Item Not Available");
                Name_textBox.Clear();
                Size_textBox.Clear();
                CustomerNumber_textBox.Clear();

                Quantity_textBox.Clear();
            }
          
        }


        private void EnterInSystem_Load(object sender, EventArgs e)
        {

        }
        public float CustomerLimit(int customerNo)
        {
            float Customerlimit = 0;
            customers = null;
            customers = customer.AllCustomers;

            foreach (Customer aCustomer in customers)
            {
                if (aCustomer.CustomerNumber == customerNo)
                {
                    Customerlimit = aCustomer.CreditLimit;
                    break;
                }

            }
            return Customerlimit;

        }
            
         void addedIterm(Product item)
        {
            if (available == true)
            {
                Console.WriteLine(item.ProductName);
                Product productObj = item;
                productController.AddToCart(productObj);
                
            }
            Name_textBox.Clear();
            Size_textBox.Clear();
            CustomerNumber_textBox.Clear();

            Quantity_textBox.Clear();
        }
          
    
        private void AddCart_button_Click(object sender, EventArgs e)
        {
            CartItem();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewCartToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void viewCartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            popelHome = (PopelsHome)this.MdiParent;
            popelHome.ViewCartWindow(sender, e, custNumber);
        }
    }
}
