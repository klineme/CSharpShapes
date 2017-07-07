using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class ShapeZeroAreaException : Exception
    {
        public ShapeZeroAreaException(string message) : base(message)
        {
        }
    }
}
