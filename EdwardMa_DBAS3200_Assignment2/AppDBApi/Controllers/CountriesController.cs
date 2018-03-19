using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace AppDBApi.Controllers
{
    public class CountriesController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool CountryExists(string key)
        {
            return db.Country.Any(c => c.Code == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD
        //GET
        [EnableQuery]
        public IQueryable<Country> Get()
        {
            return db.Country;
        }
        [EnableQuery]
        public SingleResult<Country> Get([FromODataUri] string key)
        {
            IQueryable<Country> result = db.Country.Where(c => c.Code == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Country.Add(country);
            await db.SaveChangesAsync();
            return Created(country);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<Country> country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Country.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            country.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(entity);
        }

        //DELETE

        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            var course = await db.Country.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.Country.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}