using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _19___Web_Services
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 obj = new WebService1();
        protected void Page_Load(object sender, EventArgs e) { }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "welcome Mr./Mrs. " + obj.getname(TextBox1.Text) + "<br/> your account number is " + obj.getaccountnumber(Convert.ToInt32(TextBox2.Text)).ToString();
        }
    }
}