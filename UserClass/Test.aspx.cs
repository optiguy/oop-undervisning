using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserClass
{
    public partial class Test : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowLoginStatus();
        }

        private void ShowLoginStatus()
        {
            if (Optiguy.User.IsUser())
            {
                Optiguy.User currentUser = Optiguy.User.getCurrentUser();
                lbl_user.Text = "Du er logget på som " + currentUser.Username;
            }
            else
            {
                lbl_user.Text = "Du er IKKE logget på!";
            }
        }

        protected void btn_opret_Click(object sender, EventArgs e)
        {
            Optiguy.User.CreateSession(new Optiguy.User());
            ShowLoginStatus();
        }

        protected void btn_slet_Click(object sender, EventArgs e)
        {
            Optiguy.User.RemoveSession();
            ShowLoginStatus();
        }

        protected void brn_login_Click(object sender, EventArgs e)
        {
            if (Optiguy.User.Login("Optiguy", "1234"))
            {
                //ja
            }
            else
            {
                //Fejl
            }
            ShowLoginStatus();
        }

        protected void Button_logout_Click(object sender, EventArgs e)
        {
            Optiguy.User.Logout();
            ShowLoginStatus();
        }
    }
}