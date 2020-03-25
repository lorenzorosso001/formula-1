using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class DriversController : ApiController
    {
        DbTools db = new DbTools();
        public IEnumerable<Driver> GetAllDrivers()
        {
            db.GetDrivers();
            return db.Drivers.Values;
        }
        public IHttpActionResult GetDriver(int id)
        {
            db.GetDrivers();
            if (db.Drivers[id] == null)
                return NotFound();

            return Ok(db.Drivers[id]);
        }
    }
}
