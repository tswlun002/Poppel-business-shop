using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder_system.CustomerEntities
{
    public class Customer
    {
        #region CUSTOMER FIELDS
        private string customer_name;
        private int customer_number;
        private int customer_AccoountNumber;
        private string customer_address;
        private string customer_email;
        private int ccNumber;
        private string ccExpireDate;
        private string customer_telephoneNumber;
        private string customer_creditStatus;
        private float cutomer_creditLimit;
        private float currentBalance;
        #endregion

        #region CUSTOMER PROPERTY METHODS
        public int CustomerNumber
        {
            get
            {
                return customer_number;
            }
            set
            {
                customer_number = value;
            }
        }
        public int AccountnUmber
        {
            get
            {
                return customer_number;
            }
            set
            {
                customer_number = value;
            }
        }
        public string Name
        {
            get
            {
                return customer_name;
            }
            set
            {
                customer_name = value;
            }
        }
        public string CCExpireDate
        {
            get
            {
                return ccExpireDate;
            }
            set
            {
                ccExpireDate = value;
            }
        }
        public int CCNumber
        {
            get
            {
                return ccNumber;
            }
            set
            {
                ccNumber = value;
            }
        }
        public float CreditLimit
        {
            get
            {
                return cutomer_creditLimit;
            }
            set
            {
                cutomer_creditLimit = value;
            }
        }
        public float CurrentBalance
        {
            get
            {
                return currentBalance;
            }
            set
            {
                currentBalance = value;
            }
        }
        public string CustomerTelephoneNumber
        {
            get
            {
                return customer_telephoneNumber;
            }
            set
            {
                customer_telephoneNumber = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customer_address;
            }
            set
            {
                customer_address = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return customer_email;
            }
            set
            {
                customer_email = value;
            }
        }
        public string CreditStatus
        {
            get
            {
                return customer_creditStatus;
            }
            set
            {
                customer_creditStatus = value;
            }
        }
        
        #endregion


        #region CUSTOMER CONSTRUCTOR
        public Customer()
        {
            this.customer_name = null;
            customer_number = 0;
            this.customer_telephoneNumber = null;
            this.customer_email = null;
            this.customer_address = null;

        }
        public Customer(int custNumber,int accountNo,String name, String phoneNumber,string email,string address,int ccNo,string ccExpiredate)
        {
            this.customer_name = name;
            this.customer_AccoountNumber = accountNo;
            this.customer_number = custNumber;
            this.customer_telephoneNumber = phoneNumber;
            this.customer_email = email;
            this.customer_address = address;
        }
        #endregion
    }
}
