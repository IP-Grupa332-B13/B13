using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace TeamProject_Soft
{
    public partial class ViewProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            
            if (Request.QueryString["id"]!=null)
            {
                string postId = Request.QueryString["id"].ToString();
                string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Tudor\Documents\GitHub\B13\TeamProject Soft\TeamProject Soft\App_Data\DATA_TeamProjectSoft.mdf"";Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("select id_project, title, description, id_client, price, start_date, dead_line from project where id_project = '" + postId + "'", connection);
                SqlDataReader sr = command.ExecuteReader();
                if (sr.Read())
                {
                    if (!IsPostBack)
                    {
                        TextBox1.Text = sr.GetValue(1).ToString();
                        TextBox2.Text = sr.GetValue(2).ToString();
                        TextBox3.Text = sr.GetValue(4).ToString();
                        TextBox4.Text = sr.GetValue(5).ToString();
                        TextBox5.Text = sr.GetValue(6).ToString();
                    }
                }
                connection.Close();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!=null)
            {
            string postId = Request.QueryString["id"].ToString();
           
                string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Tudor\Documents\GitHub\B13\TeamProject Soft\TeamProject Soft\App_Data\DATA_TeamProjectSoft.mdf"";Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("update project set title='" + TextBox1.Text + "', description='" + TextBox2.Text + "', price='" + TextBox3.Text + "' where id_project = '" + postId +"'", connection);
 
                if (command.ExecuteNonQuery() == 0)
                {
                    Console.Write("failed");
                    TextBox1.Text = "failed";
                }
                else
                {
                    Console.Write("succ");
                
                }
                connection.Close();
            }
            else
            {
                string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Tudor\Documents\GitHub\B13\TeamProject Soft\TeamProject Soft\App_Data\DATA_TeamProjectSoft.mdf"";Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
                SqlConnection connection = new SqlConnection(con);
                connection.Open();
                SqlCommand command = new SqlCommand("insert into project(title,description,price,start_date,dead_line) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')", connection);

                if (command.ExecuteNonQuery() == 0)
                {
                    Console.Write("faild");
                }
                else
                {
                    Console.Write("succ");
                }
                connection.Close();
            }

        }
    }
}