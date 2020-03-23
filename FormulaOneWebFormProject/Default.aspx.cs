using FormulaOneDll;
using System;
using System.Web.UI.WebControls;

namespace FormulaOneWebFormProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected DbTools db;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DbTools();
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            //db.GetCountries();
            GridView1.DataSource = db.Countries.Values;
            GridView1.AutoGenerateSelectButton = false;
            GridView1.DataBind();
        }

        protected void btnLoadDrivers_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = db.Drivers.Values;
            GridView1.AutoGenerateSelectButton = false;
            GridView1.DataBind();
        }

        protected void btnLoadTeams_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = db.Teams;
            GridView1.AutoGenerateSelectButton = true;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            Team team = db.Teams.Find(t => t.ID == id);
            idTeam.Text = team.ID.ToString();
            nameTeam.Text = team.Name;
            fullNameTeam.Text = team.FullTeamName;
            countryTeam.Text = team.Country.CountryName;
            powerUnitTeam.Text = team.PowerUnit;
            technicalChiefTeam.Text = team.TechnicalChief;
            chassisTeam.Text = team.Chassis;
            nameFirstTeam.Text = team.FirstDriver.ToString();
            nameSecondDriver.Text = team.SecondDriver.ToString();
            countryTeam.DataBind();
            powerUnitTeam.DataBind();
            technicalChiefTeam.DataBind();
            chassisTeam.DataBind();
            nameFirstTeam.DataBind();
            nameSecondDriver.DataBind();
        }
    }
}