using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WIN-BNORA0NIVEB\SQLEXPRESS;Initial Catalog=PRACTISE;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"
INSERT INTO[dbo].[Table1]
           ([ID]
           ,[name]
           ,[phone]
           ,[Adress])
     VALUES
           ('" +txtID.Text+ "','" +txtName.Text+ "','" +txtPhone.Text+ "','" +txtAdress.Text+ "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Inserted successfully");
            con.Close();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WIN-BNORA0NIVEB\SQLEXPRESS;Initial Catalog=PRACTISE;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[Table1]
      WHERE [ID]='" +txtID.Text+ "'",con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Deleted successfully");
            con.Close();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WIN-BNORA0NIVEB\SQLEXPRESS;Initial Catalog=PRACTISE;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE [dbo].[Table1]
   SET [ID] ='" + txtID.Text + "',[name] ='" + txtName.Text + "',[phone] = '" + txtPhone.Text + "',[Adress] = '" + txtAdress.Text + "' WHERE [ID]='" + txtID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data Deleted successfully");
            con.Close();
        }
    }
}