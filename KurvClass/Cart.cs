using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Optiguy
{
    public class Cart
    {
        private List<CartProduct> items; //This is all the items in the cart

        public Cart()
        {
            this.items = GrabCart();
        }

        public List<CartProduct> Items { get { return this.items; } }

        private List<CartProduct> GrabCart()
        {
            List<CartProduct> cart = new List<CartProduct>();
            
            if (HttpContext.Current.Session["Cart"] == null)
            {
                HttpContext.Current.Session.Add("Cart", cart);
            }

            cart = HttpContext.Current.Session["Cart"] as List<CartProduct>;
            return cart;
        }

        public void AddToCart(int id, string name, decimal price, int amount)
        {
            CartProduct product = findProduct(id);
            if (product.Id != 0)
            {
                product.Amount += amount;
            } else {
                this.items.Add(new CartProduct(id,name,price,amount));
            }
        }

        public void SetAmountOnProduct(int id, int newAmount) {
            CartProduct item = findProduct(id);
            item.Amount = newAmount;
        }

        public void addAmountOnProduct(int id, int amountToAdd) {
            CartProduct item = findProduct(id);
            item.Amount += amountToAdd;
        }
        public void reduceAmountOnProduct(int id, int amountToReduce) {
            CartProduct item = findProduct(id);
            item.Amount -= amountToReduce;
        }

        public CartProduct findProduct(int id)
        {
            foreach (CartProduct product in this.items)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }

            return new CartProduct();
        }
    }
}