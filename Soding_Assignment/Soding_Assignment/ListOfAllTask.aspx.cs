using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soding_Assignment
{
    public partial class ListOfAllTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label_NotFoundData.Visible = false;
        }

        protected void Button_HomeFromList_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void Button_CreateTaskFromList_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Create_Task.aspx");
        }

        protected void Button_Search_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=DESKTOP-N8E3CE8;Initial Catalog=Soding_Assignment;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "SELECT * FROM Task_Details WHERE id = '" + TextBox_SearchID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TextBox_UpdateName.Text = reader.GetValue(1).ToString();
                TextBox_UpdateDescription.Text = reader.GetValue(2).ToString();
            }
            else
            {
                Label_NotFoundData.Visible = true;
            }
            conn.Close();
        }

        protected void Button_Update_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=DESKTOP-N8E3CE8;Initial Catalog=Soding_Assignment;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
                string sql = "UPDATE Task_Details SET name = '" + TextBox_UpdateName.Text + "', description = '" + TextBox_UpdateDescription.Text + "', dateUpdated = '"+ DateTime.Now +"' WHERE id = '" + TextBox_SearchID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("~/ListOfAllTask.aspx");
                conn.Close();
        }
    }
}