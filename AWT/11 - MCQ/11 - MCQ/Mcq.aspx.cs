using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _11___MCQ
{
    public partial class Mcq : System.Web.UI.Page
    {
        
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MCQ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            con.Open();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

           
            string q = "select answer from quiz"; 
            SqlCommand cm = new SqlCommand(q, con); 
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt); 
            int count = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (RadioButton2.Checked)
                {
                    if (RadioButton2.Text.Equals(row["answer"].ToString().Trim()))
                    { count++; }
                }
                if (RadioButton5.Checked)
                {
                    if (RadioButton5.Text.Equals(row["answer"].ToString().Trim()))
                    { count++; }
                }
                if (RadioButton10.Checked)
                {
                    if (RadioButton10.Text.Equals(row["answer"].ToString().Trim()))
                    { count++; }
                }
                if (RadioButton14.Checked)
                {
                    if (RadioButton14.Text.Equals(row["answer"].ToString().Trim()))
                    { count++; }
                }
            }

            string a = "abc";
            string b = "abc";
            Label6.Text = "Results is: " + (a==b)+" = "+a.Equals(b)+" = "+count; 
            con.Close();
        }

    }
}