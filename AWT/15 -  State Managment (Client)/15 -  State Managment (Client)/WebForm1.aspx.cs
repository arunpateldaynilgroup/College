using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _15____State_Managment__Client_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int counter
        {
            get
            {
                if (ViewState["pcounter"] != null)
                {
                    return ((int)ViewState["pcounter"]);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                ViewState["pcounter"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = counter.ToString(); counter++;
        }
        protected void Button1_Click(object sender, EventArgs e) { }

}
}