using SchoolDBModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
namespace SchoolDbService.Controllers
{
    public class DepartmentsController : ODataController
    {
        SchoolDBContext db = new SchoolDBContext();
        private bool DepartmentExists(int key)
        {
            return db.Departments.Any(c => c.DepartmentID == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        //CRUD
        //GET
        [EnableQuery]
        public IQueryable<Department> Get()
        {
            return db.Departments;
        }
        [EnableQuery]
        public SingleResult<Department> Get([FromODataUri] int key)
        {
            IQueryable<Department> result = db.Departments.Where(d => d.DepartmentID == key);
            return SingleResult.Create(result);
        }

        //POST
        public async Task<IHttpActionResult> Post(Department department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Departments.Add(department);
            await db.SaveChangesAsync();
            return Created(department);
        }

        //UPDATE

        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Department> department)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Departments.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            department.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentExists(key))
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
            var Department = await db.Departments.FindAsync(key);
            if (Department == null)
            {
                return NotFound();
            }
            db.Departments.Remove(Department);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
