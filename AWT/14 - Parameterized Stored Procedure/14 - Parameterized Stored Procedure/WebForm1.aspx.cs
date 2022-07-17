using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _14___Parameterized_Stored_Procedure
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = null;
        SqlDataReader rdr = null;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pract14;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("graderange", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add( new SqlParameter("@START", Convert.ToInt32(TextBox1.Text))); 
            cmd.Parameters.Add( new SqlParameter("@END", Convert.ToInt32(TextBox2.Text)));
            
            rdr = cmd.ExecuteReader();
            
            while (rdr.Read()) {
                Label1.Text += rdr["name"].ToString() + "\t" + rdr["marks"].ToString();
                Label1.Text += " <br />";
            }
        }
    }
}