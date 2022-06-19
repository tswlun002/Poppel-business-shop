using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrder_system.CustomerEntities;

namespace CustomerOrder_system.DatabaseLayer
{
    class CustomerInfoDB:DB
    {
        #region FIELDS
        private Customer customer;
        //private Account account;
        ///private CustomerAddress address;
        private string table1 = "Custormer";
        private string sql_SELECT1 = "SELECT * FROM Customer";
        Collection<Customer> customers;
        #endregion

        #region CRUD 
        public String GetValueString(Customer aCustomer)
        {
            String aStr;
            aStr = aCustomer.CustomerNumber + ", ' " +aCustomer.Name + " ' ," + " ' " + aCustomer.CustomerTelephoneNumber + " ' ," +
                     " ' " + (aCustomer.CustomerEmail)  + " ' ," + " ' " + aCustomer.CustomerAddress + " ' ," + " ' "+ aCustomer.AccountnUmber + " ' ," +
                  " ' "+   aCustomer.CCNumber + " ' ," + " ' " + aCustomer.CCExpireDate + " ' ," + " ' " + aCustomer.CreditStatus +" ' ," +" ' "  + aCustomer.CreditLimit + " ' ," +
                    " ' "+ aCustomer.CurrentBalance + " ' ";
            return aStr;
        }
        public void DatabaseAdd(Customer aCustomer)
        {
            String strSQL = "";
            strSQL = "INSERT into Customer(CustomerNumber, Fullname, Telephone, Email, Address, AccountNumber, CCNumber, CCExpireDate, CreditStatus, CreditLimit, CurrentBalance)" +
                "VALUES(" + GetValueString(aCustomer) + ")";

            Console.WriteLine(UpdateDataSource(new SqlCommand(strSQL, cnMain)));
            
        }

        #endregion

        #region Property Methods
        /**
         *  Return data from inventory which is stock available 
         * 
         */
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
            set
            {
                customers = value;
            }
        }
      
        #endregion

        #region Constructor
        public CustomerInfoDB()
            : base()
        {
            customers = new Collection<Customer>();
            ReadaDataFromTable(sql_SELECT1, table1);
          
        }
        #endregion

        #region Data Reader

        /**
         * Read get details of the product from table 
         * add them product/item into collection
         */
        private void FillCustomer(SqlDataReader reader, string dataTable, Collection<Customer> customers)
        {
            while (reader.Read())
            {
                customer = new Customer();

                customer.CustomerNumber = reader.GetInt32(0);
                customer.Name = reader.GetString(1).Trim();
                customer.CustomerTelephoneNumber = reader.GetString(2).Trim();
                customer.CustomerEmail = reader.GetString(3).Trim();
                customer.CustomerAddress = reader.GetString(4).Trim();
                customer.AccountnUmber = reader.GetInt32(5);
                customer.CCNumber = reader.GetInt32(6);
                customer.CCExpireDate = reader.GetString(7).Trim();
                customer.CreditStatus = reader.GetString(8).Trim();
                customer.CreditLimit = (float)reader.GetDouble(9);
                customer.CurrentBalance = (float)reader.GetDouble(10);
               
                //add student to th
                customers.Add(customer);
            }
        }
     

        /**
         *  Read from table using the SQL commands
         *  This act as helper method of FillProduct method
         */
        private string ReadaDataFromTable(string selectString, string table)
        {
            SqlDataReader read;
            SqlCommand command;
            try
            {
                command = new SqlCommand(selectString, cnMain);
                cnMain.Open();
                command.CommandType = CommandType.Text;
                read = command.ExecuteReader();
                if (read.HasRows)
                {
                    if (table1.Equals(table))
                    {
                        FillCustomer(read, table, customers);
                    }
                  
                }
                read.Close();
                cnMain.Close();

                return "success";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }


        }
        #endregion
    }
}
