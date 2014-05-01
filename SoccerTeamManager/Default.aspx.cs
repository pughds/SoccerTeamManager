using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SoccerTeamManager
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Set up connection to database
                string conn = @"Data Source=localhost; Database=soccerdata; User ID=root; Password='password'";
                using (MySqlConnection cn = new MySqlConnection(conn))
                {
                    //Open database connection
                    cn.Open();

                    var teams = "SELECT teamName FROM teams";
                    var players = "SELECT playerName FROM players";

                    //Populate Team Name ListBox
                    using (MySqlCommand cmd = new MySqlCommand(teams, cn))
                    {
                        var dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        listTeamNames.DataSource = dt;
                        listTeamNames.DataValueField = "teamName";
                        listTeamNames.DataBind();

                    }

                    //Populate Player Name ListBox
                    using (MySqlCommand cmd = new MySqlCommand(players, cn))
                    {
                        var dt = new DataTable();
                        dt.Load(cmd.ExecuteReader());

                        listPlayerNames.DataSource = dt;
                        listPlayerNames.DataValueField = "playerName";
                        listPlayerNames.DataBind();

                    }

                    cn.Close();
                }
            }
        }

        //Redirect to team creation page
        protected void btnAddTeam_Click(object sender, EventArgs e)
        {
            Response.Redirect("createTeamPage.aspx");
        }

        //Redirect to player creation page
        protected void btnAddPlayer_Click(object sender, EventArgs e)
        {
            Response.Redirect("createPlayerPage.aspx");
        }

        //Logic to delete a team from the database
        protected void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=localhost; Database=soccerdata; User ID=root; Password='password'; Allow User Variables=true";
            using (MySqlConnection cn = new MySqlConnection(conn))
            {
                cn.Open();
                string selected = listTeamNames.SelectedValue.ToString();
                string comm = "DELETE FROM teams WHERE teamName='" + selected + "'";
                MySqlCommand command = new MySqlCommand(comm, cn);
                command.ExecuteReader();

                cn.Close();
            }

            Response.Redirect("Default.aspx");
        }

        //Logic to delete a player from the database
        protected void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=localhost; Database=soccerdata; User ID=root; Password='password'; Allow User Variables=true";
            using (MySqlConnection cn = new MySqlConnection(conn))
            {
                cn.Open();
                string selected = listPlayerNames.SelectedValue.ToString();
                string comm = "DELETE FROM players WHERE playerName='" + selected + "'";
                MySqlCommand command = new MySqlCommand(comm, cn);
                command.ExecuteReader();

                cn.Close();
            }

            Response.Redirect("Default.aspx");
        }



    }
}