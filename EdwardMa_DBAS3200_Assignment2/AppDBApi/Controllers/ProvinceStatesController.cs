using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace AppDBApi.Controllers
{
    public class ProvinceStatesController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool ProvinceStateExists(string key)
        {
            return db.ProvinceStates.Any(p => p.Code == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD

        //GET
        [EnableQuery]
        public IQueryable<ProvinceState> Get()
        {
            return db.ProvinceStates;
        }

        [EnableQuery]
        [ODataRoute("ProvinceStates(Code={provinceStates},CountryCode={countryCode})")]
        public SingleResult<ProvinceState> Get([FromODataUri] string provinceStates, [FromODataUri] string countryCode)
        {
            IQueryable<ProvinceState> result = db.ProvinceStates.Where(p => p.Code == provinceStates && p.CountryCode == countryCode);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(ProvinceState provinceState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.ProvinceStates.Add(provinceState);
            await db.SaveChangesAsync();
            return Created(provinceState);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<ProvinceState> provinceState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.ProvinceStates.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            provinceState.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProvinceStateExists(key))
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

        public async Task<IHttpActionResult> Delete([FromODataUri] string key)
        {
            var course = await db.ProvinceStates.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.ProvinceStates.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}