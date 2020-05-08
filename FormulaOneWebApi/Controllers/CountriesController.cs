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
        public IHttpActionResult GetCountry(string id)
        {
            try
            {
                db.GetCountries();
                if (db.Countries[id] == null)
                    return NotFound();

                return Ok(db.Countries[id]);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
