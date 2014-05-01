using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoccerTeamManager
{
    public partial class createTeamPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Method reads user input and inserts team into the database
        protected void Button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=localhost; Database=soccerdata; User ID=root; Password='password'";
            using (MySqlConnection cn = new MySqlConnection(conn))
            {
                cn.Open();
                string comm = "INSERT INTO teams (teamname) VALUES ('" + txtTeamName.Text + "')";
                MySqlCommand command = new MySqlCommand(comm, cn);
                command.ExecuteNonQuery();

                cn.Close();
            }

            Response.Redirect("Default.aspx");
        }

        

        
    }
}