using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    [RoutePrefix("api")]
    public class CircuitsController : ApiController
    {
        DbTools db = new DbTools();

        //attribute routing
        [Route("circuits")]
        [HttpGet]
        public IEnumerable<Circuit> GetAllCircuits()
        {
            try
            {
                db.LoadCircuits();
                return db.Circuits;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //attribute routing
        [Route("circuits/{id}/details")]
        [HttpGet]
        public IHttpActionResult GetCircuit(int id)
        {
            try
            {
                db.LoadCircuits();
                if (db.Circuits[id] == null)
                    return NotFound();

                return Ok(db.Circuits[id]);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
