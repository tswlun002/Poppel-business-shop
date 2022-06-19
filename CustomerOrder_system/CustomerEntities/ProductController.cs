using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrder_system.DatabaseLayer;

namespace CustomerOrder_system.CustomerEntities
{
    public  class ProductController
    {
        #region Data Members
        InventoryInfoDB productDB;
        private Collection<Product> products;
        private Collection<Product> Cartproducts;
        #endregion

        #region Property Methods
        public Collection<Product> AllProducts
        {
            get
            {
                return products;
            }
        }
        public Collection<Product> AllCartProducts
        {
            get
            {
                return Cartproducts;
            }
        }
        #endregion
        public void AddToCart(Product product)
        {
          
            Cartproducts.Add(product);
        }
        #region Constructors
        public ProductController()
        {
            productDB = new InventoryInfoDB();
            products = productDB.AllProducts;
            Cartproducts = new Collection<Product>();

        }
        #endregion
    }
}
