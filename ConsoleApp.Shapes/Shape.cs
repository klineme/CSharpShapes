using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class Shape
    {
        //Constructor
        public Shape()
        {
            this.length = 0;
            this.width = 0;
        }
        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="length">Shape Length</param>
        /// <param name="width">Shape Width</param>
        public Shape(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        //fields or variables
        private int length;
        private int width;

        public virtual double Area()
        {
            if (length * width == 0)
            {
                throw new ShapeZeroAreaException($"Area is 0, length is {length} and width is {width}");
            }
            return this.width * this.length;
        }
        public string GetShapeInfo()
        {
            string result = "";

            result = $"height is {this.length}\nwidth is {this.width}";

            return result;
        }
    }
}
