using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Optiguy
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
        public List<CartProduct> Products { get { return this.products; } }

        public Order(int userId) {
            this.userId = userId;
            this.createdDate = DateTime.Now;
        }

        public void addProduct(CartProduct item){
            this.products.Add(item);
        }

        public void saveOrder() {
            //Opret en ordre i databasen - Returner id'et
            //Brug id'et fra ordren til at oprette alle ordre linier med.
        }

    }
}