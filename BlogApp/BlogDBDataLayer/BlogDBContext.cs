using System.Data.Entity;
using BlogDBDataLayer.Models;
namespace BlogDBDataLayer
{
    public class BlogDBContext : DbContext
    {
        public BlogDBContext() : base("BlogDB")
        {

        }
        //define the collection of objects in the database... aka tables
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
