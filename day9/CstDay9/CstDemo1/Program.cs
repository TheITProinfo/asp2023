using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird bd1 = new Bird();
            bd1.Flying();
            bd1.Taxcalculator();
            Console.ReadKey();

            Palne p1 = new Palne();
            p1.Flying();

        }
    }
}
