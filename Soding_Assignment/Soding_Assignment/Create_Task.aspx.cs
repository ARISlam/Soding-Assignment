using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soding_Assignment
{
    public partial class Create_Task : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_HomeFromCT_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void Button_ListOfAllTaskFromCT_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ListOfAllTask.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=DESKTOP-N8E3CE8;Initial Catalog=Soding_Assignment;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "INSERT INTO Task_Details VALUES ('" + TextBox_CreateName.Text + "', '" + TextBox_CreateDescription.Text + "', '" + DateTime.Now + "','Not yet Update')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery(); 
            Label_TaskCreateConfirmation.Visible = true;
            conn.Close();

            TextBox_CreateName.Text = "";
            TextBox_CreateDescription.Text = "";
        }
    }
}