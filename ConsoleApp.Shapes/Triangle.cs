using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int length, int width) : base(length, width)
        {
        }
        public override double Area()
        {
            return base.Area() / 2;
        }
    }
}
