using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _16___Persistent_And_Non_Persistent_Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Persistance"] != null) Label1.Text = Request.Cookies["Persistance"].Value;
            else
                Label1.Text = "";
            if (Request.Cookies["NonPersistance"] != null)
                Label2.Text = Request.Cookies["NonPersistance"].Value;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Persistent Cookies*/
            HttpCookie aCookieValPer = new HttpCookie("Persistance"); aCookieValPer.Value = "This is A Persistance Cookie"; aCookieValPer.Expires = DateTime.Now.AddSeconds(10); Response.Cookies.Add(aCookieValPer);
            /*Non Persistent Cookies*/
            HttpCookie aCookieValNonPer = new HttpCookie("NonPersistance"); aCookieValNonPer.Value = "This is A Non Persistance Cookie"; Response.Cookies.Add(aCookieValNonPer);
        }
    }
}