using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class RacesController : ApiController
    {
        DbTools db = new DbTools();

        //attribute routing
        [Route("races")]
        [HttpGet]
        public IEnumerable<Race> GetAllCircuits()
        {
            try
            {
                db.LoadRaces();
                return db.Races;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //attribute routing
        [Route("races/{id}/details")]
        [HttpGet]
        public IHttpActionResult GetRace(int id)
        {
            try
            {
                db.LoadRaces();
                if (db.Races[id] == null)
                    return NotFound();

                return Ok(db.Races[id]);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
