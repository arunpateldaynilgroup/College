using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace _19___Web_Services
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public WebService1()
        {
            //Uncomment the following line if using designed components
            //InitializeComponent();
        }
        [WebMethod]
        public string getname(string nm)
        { return nm; }
        [WebMethod]
        public int getaccountnumber(int a)
        { return a; }
    }
}
