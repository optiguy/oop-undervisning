using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                Convert.ToInt32(TB_amount.Text),
                "http://placehold.it/50x50"
            );
            CartViewControl.Refresh();
        }
        
    }
}