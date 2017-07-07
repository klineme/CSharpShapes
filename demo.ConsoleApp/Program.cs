using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Shapes;

namespace demo.ConsoleApp
{
    class Program
    {
        //Private

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for(int i = 1; i < 101; i++)
            {
                if (i % 5 == 0)
                    shapes.Add(new Triangle(i, i * 3));
                else
                    shapes.Add(new Rectangle(i, i));
            }
            var bigArea = shapes.Where(s => s.Area() > 25).ToList();
            var rectangles = shapes.Where(s => s is Rectangle).ToList();
            foreach (var item in bigArea)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
