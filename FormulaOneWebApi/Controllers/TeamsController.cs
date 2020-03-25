using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class TeamsController : ApiController
    {
        DbTools db = new DbTools();

        public IEnumerable<Team> GetAllTeams()
        {
            db.LoadTeams();
            return db.Teams;
        }
        public IHttpActionResult GetTeam(int id)
        {
            db.LoadTeams();
            if (db.Teams[id] == null)
                return NotFound();

            return Ok(db.Teams[id]);
        }
    }
}
