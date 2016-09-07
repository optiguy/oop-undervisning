using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KurvClass
{

    public class Order
    {
        private int orderId;
        private int userId; 
        private DateTime createdDate;
        private List<CartProduct> products;
        
        public int OrderId { get { return this.orderId; } }
        public int UserId { get { return this.userId; } set { this.userId = value; } }
        public DateTime CreatedDate { get { return this.createdDate; } set { this.createdDate = value; } }
        public List<CartProduct> Products { get { return this.products; } set { this.products = value; } }

        public Order(int userId)
        {
            this.userId = userId;
            this.createdDate = DateTime.Now;
        }

        public void addProduct(CartProduct item)
        {
            this.products.Add(item); 
        }

        public bool saveOrder()
        {
            string sql = "INSERT INTO Orders (CreatedDate, UsersId) VALUES (" + this.createdDate + "," + this.userId + ")";
            try
            {
                int orderId = Database.InsertAndGetId(sql);
                try
                {
                    foreach (CartProduct product in this.products)
                    {
                        string itemSql = "INSERT INTO OrderItems (OrdersId, ProductsId, Price, Amount) VALUES (" + orderId + "," + product.Id + "," + product.Price + "," + product.Amount + ")";
                        Database.Query(itemSql);
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}