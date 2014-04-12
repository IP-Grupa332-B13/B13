using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TeamProject_Soft
{
    public partial class LoginPage : System.Web.UI.Page
    {
        static string Connection = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=""D:\GitHub\B13\TeamProject Soft\TeamProject Soft\App_Data\DATA_TeamProjectSoft.mdf"";Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        SqlConnection SqlConnection1 = new SqlConnection(Connection);
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            bool ok = true;
            for (int i = 0; i < TextBox_LoginUsername.Text.Length; i++)
            {
                if (TextBox_LoginUsername.Text.ElementAt(i) == ';')
                {
                    ok = false;
                }
            }
            if (ok == true)
            {
                SqlConnection1.Open();
                SqlCommand Command = new SqlCommand("Select * from dbo.employee where user_name = '" +
                    TextBox_LoginUsername.Text + "' and password = '" +
                    TextBox_LoginPass.Text + "' ", SqlConnection1);
                SqlDataReader reader = Command.ExecuteReader();
                int id;
                while (reader.Read())
                {
                    Page.Session["user"] = reader.GetString(1) + " - " + reader.GetString(2);
                    id = reader.GetInt32(0);
                    Page.Session["id"] = id;
                    //ListUtilizatori.Add(id);
                    // Page.Session["utilizatori"] = ListUtilizatori;
                    Page.Session["rank"] = reader.GetInt32(8);
                    // Panel1.Visible = false;
                }
                Label2.Text = Page.Session["user"].ToString();
                reader.Close();
                SqlConnection1.Close();
            }
        }
    }
}