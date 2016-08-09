using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Optiguy
{
    public class CartProduct
    {
        #region fields
        private int id;
        private string name;
        private decimal price;
        private int amount;
        private decimal totalPrice;
        #endregion

        #region properties
        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public int Amount { get { return this.amount; } set { this.amount = value; } }
        public decimal TotalPrice { get { return this.totalPrice; } set { this.totalPrice = value; } }
        #endregion

        #region constructors
        public CartProduct() { }
        public CartProduct(int id, string name, decimal price, int amount) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.totalPrice = this.price * this.amount;
        }

        #endregion

        #region methods
        #endregion
    }
}