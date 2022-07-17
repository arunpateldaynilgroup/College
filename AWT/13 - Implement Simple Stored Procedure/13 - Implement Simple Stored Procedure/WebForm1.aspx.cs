using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace _13___Implement_Simple_Stored_Procedure
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = null; SqlDataReader rdr = null;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prac13;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("top5", conn);
            // 2. set the command object so it knows
            // to execute a stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            // execute the command
            rdr = cmd.ExecuteReader(); 
            int count = 1;
            // iterate through results, printing each to console
            while (rdr.Read()) {
                Label1.Text += " <br />";
                Label1.Text += "\t" + count.ToString() + rdr[0].ToString(); count++;
            }
        }
    }
}