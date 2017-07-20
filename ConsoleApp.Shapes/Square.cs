using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ConsoleApp.Shapes
{
    [DataContract]
    public class Square : Rectangle
    {
        public Square(int length) : base(length, length)
        {
        }
    }
}
