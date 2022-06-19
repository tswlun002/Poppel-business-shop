using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrder_system.DatabaseLayer;

namespace CustomerOrder_system.CustomerEntities
{
     public class CustomerController
    {
        #region Data Members
        CustomerInfoDB customerDB;
        private Collection<Customer> customers;
        private Customer customer;

        #endregion

        #region Property Methods
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        #endregion

        public Customer GetCustomer(int customerNo)
        {
            //customer = null;
            foreach(Customer aCustomer in AllCustomers)
            {
                if (aCustomer.CustomerNumber == customerNo)
                {
                    customer = aCustomer;
                }
            }

            return customer;
        }
        public void AddCustomer(Customer aCustomer)
        {
            customerDB.DatabaseAdd(aCustomer);
            customers.Add(aCustomer);
        }
        #region Constructors
        public CustomerController()
        {
            customerDB = new CustomerInfoDB();
            customers = customerDB.AllCustomers;
        }
        #endregion
    }
}
