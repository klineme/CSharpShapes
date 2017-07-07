using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class SingletonShapeList
    {
        private static List<Shape> shapeList; //NOT TECHNICALLY SINGLETON, Not SingletonShapeList type

        private SingletonShapeList()
        {
            shapeList = new List<Shape>();
        }
        public List<Shape> list
        {
            get
            {
                if (shapeList == null)
                    shapeList = new List<Shape>();
                return shapeList;
            }
        }
    }
}
