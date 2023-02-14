using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Shape sp1 = new Shape();

            Shape shape = new Circle(12);

           double area= shape.GetArea();
            double perimeter=shape.GetPerimeter();

            Console.WriteLine("the shpae of Area is\t{0:0.00},\t Perimeter is {1:0.00}",area,perimeter);
        }
    }
}
