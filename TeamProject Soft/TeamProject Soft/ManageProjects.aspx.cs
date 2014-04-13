using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace TeamProject_Soft
{
    public partial class ManageProjects : System.Web.UI.Page
    {
        static string Connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\Tudor\Documents\GitHub\B13\TeamProject Soft\TeamProject Soft\App_Data\DATA_TeamProjectSoft.mdf"";Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        SqlConnection SqlConnection1 = new SqlConnection(Connection);
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection1.Open();
            SqlCommand command = new SqlCommand("select id_project, title from project", SqlConnection1);
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                HyperLink btn = new HyperLink();
                btn.Text = sr.GetValue(1).ToString() + "<br>";
                btn.NavigateUrl = "~/ViewProject.aspx?id=" + sr.GetValue(0).ToString();
                Page.Controls.Add(btn);
           }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewProject.aspx");
        }
    }
}