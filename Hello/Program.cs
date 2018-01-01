using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name ="";
            foreach (var item in args)
            {
                name = name + " " + item;
            }

            Console.WriteLine("DUPA KWAS " + name.ToString());
            //Console.ReadKey();
        }
    }
}
