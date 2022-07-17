using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _12___LinqToSQLClass_Course_and_Product_CRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            var c = new Product();
            c.Name = TextBox1.Text; 
            c.price = TextBox2.Text;
            c.Id = Convert.ToInt32(TextBox3.Text); 
            d.Products.InsertOnSubmit(c); 
            d.SubmitChanges(); GridView1.DataBind();
            Label1.Text = "Successfully added data";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext(); 
            Product c = d.Products.FirstOrDefault(e1 => e1.Name.Equals(TextBox1.Text)); 
            c.Name = TextBox1.Text;
            c.price = TextBox2.Text; 
            d.SubmitChanges(); 
            GridView1.DataBind();
            Label1.Text = "Successfully updated data";
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            Product c = d.Products.FirstOrDefault(e1 => e1.Id.Equals(Convert.ToInt32(TextBox3.Text))); 
            d.Products.DeleteOnSubmit(c); 
            d.SubmitChanges();
            GridView1.DataBind();
            Label1.Text = "Successfully Deleted data";
        }
    }
}