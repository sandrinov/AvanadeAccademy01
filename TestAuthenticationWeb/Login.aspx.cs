using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAuthenticationWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Txt_UserName.Text == "MarioRossi" && Txt_Psw.Text == "password")
            {
                FormsAuthentication.RedirectFromLoginPage(Txt_UserName.Text, this.CheckBox1.Checked);
            }
            else
            {
                this.Lbl_Error.Text = "Invalid User Name and/or Password";
            }
        }
    }
}