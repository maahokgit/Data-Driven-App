using AppDBDatalayer.Models;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace AppDBApi.Controllers
{
    public class ApplicantsController : ODataController
    {
        AppDBDatalayer.AppDBContext db = new AppDBDatalayer.AppDBContext();
        private bool ApplicantExists(int key)
        {
            return db.Applicants.Any(a => a.Applicantid == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD
        //GET
        [EnableQuery]
        public IQueryable<Applicant> Get()
        {
            return db.Applicants;
        }
        [EnableQuery]
        public SingleResult<Applicant> Get([FromODataUri] int key)
        {
            IQueryable<Applicant> result = db.Applicants.Where(a => a.Applicantid == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(Applicant applicant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Applicants.Add(applicant);
            await db.SaveChangesAsync();
            return Created(applicant);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Applicant> applicant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Applicants.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            applicant.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicantExists(key))
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
            var course = await db.Applicants.FindAsync(key);
            if (course == null)
            {
                return NotFound();
            }
            db.Applicants.Remove(course);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}