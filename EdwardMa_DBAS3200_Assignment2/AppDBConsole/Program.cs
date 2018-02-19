using AppDBDatalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
