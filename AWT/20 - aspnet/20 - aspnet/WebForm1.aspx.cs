using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20___aspnet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.IService1 obj = new ServiceReference1.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToInt32(TextBox1.Text); 
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = obj.add(x, y).ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToInt32(TextBox1.Text); 
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = obj.sub(x, y).ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToInt32(TextBox1.Text); 
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = obj.mul(x, y).ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToInt32(TextBox1.Text); 
            y = Convert.ToInt32(TextBox2.Text);
            TextBox3.Text = obj.div(x, y).ToString();
        }
    }
}