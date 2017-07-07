using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Shapes
{
    public class SingletonShapeList<T> : List<T>
    {
        private static SingletonShapeList<T> shapeList; //NOT TECHNICALLY SINGLETON, Not SingletonShapeList type

        private SingletonShapeList()
        {
        }
        public SingletonShapeList<T> MyProperty {
        get
            {
                if (shapeList == null)
                    shapeList = new SingletonShapeList<T>();
                return shapeList;
            }
        }
    }
}
