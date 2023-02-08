using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstStudent01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Tom","Male",18,80,98,100);
            st1.SayHello();

            Console.ReadKey();

        }
    }
}
