using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace AppDBApi.Controllers
{
    public class ProgramChoicesController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool ProgramChoiceExists(int key)
        {
            return db.ProgramChoices.Any(p => p.Id == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD
        //GET
        [EnableQuery]
        public IQueryable<ProgramChoice> Get()
        {
            return db.ProgramChoices;
        }
        [EnableQuery]
        public SingleResult<ProgramChoice> Get([FromODataUri] int key)
        {
            IQueryable<ProgramChoice> result = db.ProgramChoices.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(ProgramChoice programChoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.ProgramChoices.Add(programChoice);
            await db.SaveChangesAsync();
            return Created(programChoice);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<ProgramChoice> programChoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.ProgramChoices.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            programChoice.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramChoiceExists(key))
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
            var course = await db.ProgramChoices.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.ProgramChoices.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}