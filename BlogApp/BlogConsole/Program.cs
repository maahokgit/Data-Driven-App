using BlogDBDataLayer;
using BlogDBDataLayer.Models;

namespace BlogConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog newBlog = new Blog();
            newBlog.Title = "My Cool New Blog";

            BlogDBContext context = new BlogDBContext();
            context.Blogs.Add(newBlog);

            context.SaveChanges();
        }
    }
}
