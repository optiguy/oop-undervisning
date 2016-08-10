using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Optiguy;

namespace KurvClass
{
    public partial class Default : System.Web.UI.Page
    {
        private Cart cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            cart = new Cart();
        }

        protected void Button_submit_Click(object sender, EventArgs e)
        {
            cart.AddToCart(
                Convert.ToInt32(TB_id.Text),
                TB_name.Text,
                Convert.ToDecimal(TB_price.Text),
                Convert.ToInt32(TB_amount.Text)
            );
            ShowCart(cart.Items);
        }
         
        private void ShowCart(List<CartProduct> cart)
        {
            GV_cart.DataSource = cart;
            GV_cart.DataBind();
        }
        
    }
}