using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    class Rectangle:IPolygon,IColor
    {
        public void CalculateArea(double a, double b)
        {
            Console.WriteLine("the Area of Rectangle is {0}",a*b);
        }

        public void GetColor()
        {
            Console.WriteLine("the color of Rectangle is blue");
        }

    }
}
