using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder_system.CustomerEntities
{
    class Order
    {
        #region ORDER FIELDS
        private int order_number;
        private string order_date;
        private string product_code;
        private string product_name;
        private string product_size;
        private int product_quantity;
        private double price;
        private double total_price;
        private string order_status;
        private string delivery_date;
        #endregion

        #region ORDER METHODS
        public int OrderNumber
        {
            get
            {
                return order_number;
            }
            set
            {
                order_number = value;
            }
        }
        public string OrderDate
        {
            get
            {
                return order_date;
            }
            set
            {
                order_date = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double TotalPrice
        {
            get
            {
                return total_price;
            }
            set
            {
                total_price = value;
            }
        }
        public string DeliveryDate
        {
            get
            {
                return delivery_date;
            }
            set
            {
                delivery_date= value;
            }
        }
        public string OrderStatus
        {
            get
            {
                return order_status;
            }
            set
            {
                order_status= value;
            }
        }
        public string ProductCode
        {
            get
            {
                return product_code;
            }
            set
            {
                product_code = value;
            }
        }

        public string ProductName
        {
            get
            {
                return product_name;
            }
            set
            {
                product_name = value;
            }
        }
        public int ProductQuantity
        {
            get
            {
                return product_quantity;
            }
            set
            {
                product_quantity = value;
            }
        }
        #endregion

        #region ORDER CONSTRUCTOR
        public Order()
        {
            this.order_number =0;
            this.order_date = null;
            this.product_code = null;
            this.product_name = null;
            this.product_quantity = 0;
            this.total_price = 0;
            this.order_status = null;
            this.delivery_date = null;
            this.price = 0;
        }
         public Order(int orderNum,string date, string productCode,string prodName,int product_quantity,double price,double totalprice,string status,string deliveryDate)
        {
            this.order_number = orderNum;
            this.order_date = date;
            this.product_code = productCode;
            this.product_name = prodName;
            this.product_quantity = product_quantity;
            this.price = price;
            this.total_price = totalprice;
            this.order_status = status;
            this.delivery_date = deliveryDate;
        }
        #endregion
    }
}
