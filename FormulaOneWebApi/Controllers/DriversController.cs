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
        Dictionary<int, Driver> lstDrivers = new Dictionary<int, Driver>();
        // GET: api/Drivers
        public IEnumerable<int, Driver> Get()
        {
            lstDrivers = db.GetDrivers();
            //da trasformare in lista singola
            return lstDrivers;
        }

        /*// GET: api/Drivers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Drivers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Drivers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Drivers/5
        public void Delete(int id)
        {
        }*/
    }
}
