using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder_system.CustomerEntities
{
    public class Product
    {
        #region FILEDS
        private int productId;
        private string name;
        private string size;
        private float price;
        private int quantity;
        private float totalPrice;
        private string description;
        private string expireDate;
        #endregion

        #region PROPERTY METHODS
        public int ProductID
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
            }
        }
        public string ProductName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string ProductSize
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string ProductDescription
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string ProductExpireDate
        {
            get
            {
                return expireDate;
            }
            set
            {
                expireDate = value;
            }
        }
        public float ProductPrice
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
        public int ProductQuantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public float ProductTotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
            }
        }
        #endregion

        #region CONSTRUCT
        public Product(int id, string name, string size,float price,int quantity,float totalprice)
        {
            this.productId = id;
            this.name = name;
            this.size = size;
            this.price = price;
            this.quantity = quantity;
            this.totalPrice = totalprice;
        }

        public Product()
        {
            this.productId =0;
            this.name =null;
            this.size = null;
            this.description = null;
            this.price =0;
            this.quantity = 0;
            this.totalPrice =0;
        }
        #endregion
    }
}
