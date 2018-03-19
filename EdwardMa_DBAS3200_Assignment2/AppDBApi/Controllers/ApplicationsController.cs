using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace AppDBApi.Controllers
{
    public class ApplicationsController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool ApplicationExists(int key)
        {
            return db.Application.Any(a => a.ApplicationId == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD
        //GET
        [EnableQuery]
        public IQueryable<Application> Get()
        {
            return db.Application;
        }
        [EnableQuery]
        public SingleResult<Application> Get([FromODataUri] int key)
        {
            IQueryable<Application> result = db.Application.Where(a => a.ApplicationId == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(Application Application)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Application.Add(Application);
            await db.SaveChangesAsync();
            return Created(Application);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Application> Application)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Application.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            Application.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationExists(key))
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
            var course = await db.Application.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.Application.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}