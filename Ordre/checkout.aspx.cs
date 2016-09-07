using KurvClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Optiguy
{
    public partial class checkout : System.Web.UI.Page
    {
        private Cart cart;
        private Order order;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cart = new Cart();
            this.order = new Order(1);
            this.order.Products = this.cart.Items;
        }

        protected void Btn_saveOrder_click(object o, EventArgs e)
        {
            if (this.order.saveOrder())
            {
                //Gemt
            }
            else
            {
                //Ikke gemt.
            }
        }
    }
}