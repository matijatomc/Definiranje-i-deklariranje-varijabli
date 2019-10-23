using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            float y = 18.5f;
            long x = Convert.ToInt64(y);
            double z = y;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.ReadKey();
        }
    }
}
