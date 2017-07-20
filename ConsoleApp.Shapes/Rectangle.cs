using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    [DataContract]
    public class Rectangle : Shape
    {
        public Rectangle(int length, int width) : base(length, width)
        {
        }
    }
}
