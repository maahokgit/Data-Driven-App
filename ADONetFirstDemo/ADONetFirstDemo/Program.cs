using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DataReadExample example = new DataReadExample();
            DataUpdateDemo update = new DataUpdateDemo();
            //example.RunDemo();
            update.RunDemo();
        }
    }
}
