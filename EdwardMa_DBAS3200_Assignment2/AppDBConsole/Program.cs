using AppDBDatalayer;

namespace AppDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDBContext context = new AppDBContext();
            context.Database.Create();

            context.SaveChanges();
        }
    }
}