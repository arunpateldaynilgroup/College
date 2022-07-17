using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23___Asp.net_Cross_Page_Posting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox textbox2;
            Calendar calendar2;
            textbox2 = (TextBox)PreviousPage.FindControl("TextBox1"); 
            calendar2 = (Calendar)PreviousPage.FindControl("Calendar1");
            Label1.Text = "Hello" + textbox2.Text + "<br/>" + "Your date of birth is" + calendar2.SelectedDate.ToShortDateString();
        }
    }
}