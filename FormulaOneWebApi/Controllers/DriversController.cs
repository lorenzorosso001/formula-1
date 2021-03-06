﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    [RoutePrefix("api")]
    public class DriversController : ApiController
    {
        DbTools db = new DbTools();

        //attribute routing
        [Route("drivers")]
        [HttpGet]
        public IEnumerable<Driver> GetAllDrivers()
        {
            try
            {
                db.GetDrivers();
                return db.Drivers.Values;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //attribute routing
        [Route("drivers/{id}/details")]
        public IHttpActionResult GetDriver(int id)
        {
            try
            {
                db.GetDrivers();
                if (db.Drivers[id] == null)
                    return NotFound();

                return Ok(db.Drivers[id]);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
