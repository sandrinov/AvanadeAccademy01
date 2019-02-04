using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAuthenticationWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Trace.IsEnabled = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //this.TextBox1.Text = this.DropDownList1.SelectedItem.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TextBox1.Text = this.DropDownList1.SelectedItem.ToString();
        }
    }
}