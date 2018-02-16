using System.Data.Entity;

namespace BlogDBDataLayer.Models
{
    public class BlogDBContext : DbContext
    {
        public DbSet<Post> MyProperty { get; set; }
    }
}
