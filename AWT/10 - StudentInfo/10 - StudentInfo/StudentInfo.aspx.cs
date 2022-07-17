using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace _10___StudentInfo
{
    public partial class StudentInfo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(); 
        SqlDataReader dr;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Student_10; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            con.Open();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int roll = Convert.ToInt16(TextBox2.Text);
            cmd = new SqlCommand("select * from Student where RollNo='" + roll + "'", con); dr = cmd.ExecuteReader();
            Label4.Visible = true; Label5.Visible = true; Label6.Visible = true; Label7.Visible = false; if (dr.Read())
            {
                Label4.Text = dr[0].ToString();          
            Label5.Text = dr[1].ToString(); Label6.Text = dr[2].ToString();
            }
            dr.Close();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string nm, sem; int roll;
            nm = TextBox1.Text;
            roll = Convert.ToInt16(TextBox2.Text); sem = TextBox3.Text;
            string qry = "insert into Student(Name,RollNo,Sem)values('" + nm + "'," + roll + ",'" + sem + "')";
            cmd = new SqlCommand(qry, con); cmd.ExecuteNonQuery(); Label7.Visible = true; Label7.Text = "data inserted sucessfully"; Label4.Visible = false;
            Label5.Visible = false; Label6.Visible = false;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            string nm, sem; int roll;
            nm = TextBox1.Text;
            roll = Convert.ToInt16(TextBox2.Text); sem = TextBox3.Text;
            cmd = new SqlCommand("update Student set Name='" + nm + "',Sem='" + sem + "' where RollNo='" + roll + "'", con);
            cmd.ExecuteNonQuery(); Label7.Visible = true;
            Label7.Text = "data updated sucessfully"; Label4.Visible = false;
            Label5.Visible = false; Label6.Visible = false;
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            int roll = Convert.ToInt16(TextBox2.Text);
            cmd = new SqlCommand("delete from Student where RollNo='" + roll + "'", con);
            cmd.ExecuteNonQuery(); Label7.Visible = true;
            Label7.Text = "data deleted sucessfully"; Label4.Visible = false;
            Label5.Visible = false; Label6.Visible = false;
        }
    }
}