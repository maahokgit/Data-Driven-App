using AppDBDatalayer.Models;
using AppDBDatalayer;

namespace AppDBConsole
{
    public class Class1
    {
        static void Main(string[] args)
        {
            AppDBContext context = new AppDBContext();
            context.Database.Create();

            context.SaveChanges();


        }
    }
}
