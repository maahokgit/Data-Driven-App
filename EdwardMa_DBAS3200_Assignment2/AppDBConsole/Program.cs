using AppDBDatalayer;

namespace AppDBConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDBContext context = new AppDBContext();

            // drop the tables in AppDB Database
            context.Database.Delete();

            // create the tables in AppDB Database
            context.Database.Create(); 
        }
    }
}