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

        private void AddToCart(int id, string name, decimal price, int amount)
        {
            bool newProduct = true;

            foreach (CartProduct product in this.items)
            {
                if (product.Id == id)
                {
                    newProduct = false;
                    product.Amount += amount;
                }
            }

            if (newProduct)
            {
                this.items.Add(new CartProduct(id,name,price,amount));
            }
        }
    }
}