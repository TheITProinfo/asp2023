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
            Cat cat = new Cat("Jacky",18,"001");

           
            cat.SayHello();
            cat.Move();
            cat.Speak();

            //cat.Sleeping();

            //Cat.Eat();
            Console.ReadKey();
          
            Cat cat2=new Cat ("Tom",12,"007");

            cat2.SayHello();
            cat2.Move();
            cat2.Speak();




           
        }
    }
}
