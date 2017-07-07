using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class Circle : Shape
    {
        private static Circle instance = null;
        //PRIVATE constructor
        private Circle() {}

        //Get the instance
        public static Circle GetCircle
        {
            get
            {
                if(instance == null)
                    instance = new Circle();
                return instance;
            }
        }

        public int Radius
        {
            get
            {
                return Length;
            }
            set
            {
                Length = value;
                Width = value;
            }
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
