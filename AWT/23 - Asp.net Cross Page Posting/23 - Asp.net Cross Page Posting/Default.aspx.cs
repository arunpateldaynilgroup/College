using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23___Asp.net_Cross_Page_Posting
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "Hello" + TextBox1.Text + "<br/>" + "Your date of birth is" + Calendar1.SelectedDate.ToShortDateString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
        }
    }
}