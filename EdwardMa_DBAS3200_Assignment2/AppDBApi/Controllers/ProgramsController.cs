using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace AppDBApi.Controllers
{
    public class ProgramsController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool ProgramExists(int key)
        {
            return db.Program.Any(p => p.Id == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD
        //GET
        [EnableQuery]
        public IQueryable<Program> Get()
        {
            return db.Program;
        }
        [EnableQuery]
        public SingleResult<Program> Get([FromODataUri] int key)
        {
            IQueryable<Program> result = db.Program.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(Program program)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Program.Add(program);
            await db.SaveChangesAsync();
            return Created(program);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Program> program)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Program.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            program.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramExists(key))
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
            var course = await db.Program.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.Program.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}