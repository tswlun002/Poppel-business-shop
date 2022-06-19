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
    class InventoryInfoDB:DB
    {
        #region FIELDS
        
        
        private string table1 = "Inventory";
        private string sql_SELECT1 = "SELECT * FROM Inventory";
        Collection<Product> stock;
        #endregion

        #region Property Methods
        /**
         *  Return data from inventory which is stock available 
         * 
         */
        public Collection<Product> AllProducts
        {
            get 
            {
                return stock;
            }
        }
        #endregion

        #region Constructor
        public InventoryInfoDB() :base()
        {
            stock = new Collection<Product>();
            ReadaDataFromTable(sql_SELECT1, table1);
        }
        #endregion

        #region CRUD
      /*  public String GetValueString(Product aproduct)
        {
            String aStr;
            aStr = aproduct.ProductID + ", ' " + aproduct.ProductName + " ' ," + " ' " + aproduct.ProductSize + " ' ," +
                     " ' " + (aproduct.ProductDescription) + " ' ," + " ' " + aproduct.ProductPrice + " ' ," + " ' " + aproduct.ProductQuantity + " ' ," +
                  " ' " + aproduct.ProductTotalPrice + " ' ," + " ' " + aproduct.ProductExpireDate + " ' ";
            return aStr;

        }
        public void AddCart(Product product)
        {
            String strSQL = "";
            strSQL = "INSERT into CartItem(ProductId, ProductName, Size, Description, Price, Quantity, TotalPrice, ExpireDate)" +
                "VALUES(" + GetValueString(product) + ")";

            Console.WriteLine(UpdateDataSource(new SqlCommand(strSQL, cnMain)));
        }*/

        #endregion

        #region Data Reader

        /**
         * Read get details of the product from table 
         * add them product/item into collection
         */
        private void FillProduct(SqlDataReader reader,string dataTable,Collection<Product> products )
        {
            Product product;
            while (reader.Read())
            {
                product = new Product();
                product.ProductID = reader.GetInt32(0);
                product.ProductName = reader.GetString(1).Trim();
                product.ProductSize = reader.GetString(2).Trim();
                product.ProductPrice = (float)reader.GetDouble(3);
                product.ProductQuantity = reader.GetInt32(4);
                product.ProductDescription = reader.GetString(5).Trim();
                product.ProductExpireDate = reader.GetString(6);
                product.ProductTotalPrice = (float)product.ProductTotalPrice + (product.ProductPrice * product.ProductQuantity);
                products.Add(product);
            }
        }


        /**
         *  Read from table using the SQL commands
         *  This act as helper method of FillProduct method
         */
        private string ReadaDataFromTable(string selectString , string table)
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
                    FillProduct(read, table, stock);
                }
                read.Close();
                cnMain.Close();

                return "success";
            }
            catch (Exception ex)
            {
                return ex.ToString()+" LUNGA TSEWU";
            }


        }
        #endregion
    }
}
