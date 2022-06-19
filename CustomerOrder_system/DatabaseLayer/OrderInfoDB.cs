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
    class OrderInfoDB:DB
    {
        #region FIELDS
        private Order order;
        private string table1 = "Order";
        private string sql_SELECT1 = "SELECT * FROM Order";
        Collection<Order> orders;
        #endregion

        #region Property Methods
        /**
         *  Return data from inventory which is stock available 
         * 
         */
        public Collection<Order> AllOrders
        {
            get
            {
                return orders;
            }
            set
            {
                orders= value;
            }
        }
        #endregion

        #region Constructor
        public OrderInfoDB()
            : base()
        {
            orders = new Collection<Order>();
            ReadaDataFromTable(sql_SELECT1, table1);
        }
        #endregion

        #region Data Reader

        /**
         * Read get details of the product from table 
         * add them product/item into collection
         */
        private void FillOrder(SqlDataReader reader, string dataTable, Collection<Order> orders)
        {
            while (reader.Read())
            {
                order = new Order();
                order.OrderNumber = reader.GetInt32(0);
                order.OrderDate = reader.GetString(1).Trim();
                order.ProductCode = reader.GetString(2).Trim();
                order.ProductName = reader.GetString(3).Trim();
                order.ProductQuantity = reader.GetInt32(4);
                order.Price = reader.GetDouble(5);
                order.TotalPrice = reader.GetDouble(6);
                order.OrderStatus = reader.GetString(7).Trim();
                order.OrderDate = reader.GetString(8).Trim();
                
                //product.ProductTotalPrice = product.ProductTotalPrice + (product.ProductPrice * product.ProductQuantity);

                //add student to th
                orders.Add(order);
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
                    FillOrder(read, table,orders);
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
