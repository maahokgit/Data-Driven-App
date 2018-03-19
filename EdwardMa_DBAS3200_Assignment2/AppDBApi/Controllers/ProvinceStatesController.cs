using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace AppDBApi.Controllers
{
    public class ProvinceStatesController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool ProvinceStateExists(string key)
        {
            return db.ProvinceState.Any(p => p.Code == key);
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
            return db.ProvinceState;
        }
        [EnableQuery]
        public SingleResult<ProvinceState> Get([FromODataUri] string key)
        {
            IQueryable<ProvinceState> result = db.ProvinceState.Where(p => p.Code == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(ProvinceState provinceState)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.ProvinceState.Add(provinceState);
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
            var entity = await db.ProvinceState.FindAsync(key);
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
            var course = await db.ProvinceState.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.ProvinceState.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}