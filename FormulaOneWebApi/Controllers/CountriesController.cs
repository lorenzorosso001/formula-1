using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FormulaOneDll;

namespace FormulaOneWebApi.Controllers
{
    public class CountriesController : ApiController
    {
        DbTools db = new DbTools();

        //attribute routing
        [Route("countries")]
        [HttpGet]
        public IEnumerable<Country> GetAllCountries()
        {
            try
            {
                db.GetCountries();
                return db.Countries.Values;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //attribute routing
        [Route("countries/{code}/details")]
        [HttpGet]
        public IHttpActionResult GetCountry(string code)
        {
            try
            {
                db.GetCountries();
                if (db.Countries[code] == null)
                    return NotFound();

                return Ok(db.Countries[code]);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
