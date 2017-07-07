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
            List<Shape> bigArea = new List<Shape>();

            for(int i = 0; i < 100; i++)
            {
                shapes.Add(new Triangle(i, i * 3));
            }
            bigArea = shapes.FindAll(s => s.Area() > 25);
            //foreach(var item in shapes)
            //{
            //    Console.WriteLine(item.GetType());
            //    Console.WriteLine(item.Area());
            //}

            Console.ReadLine();
        }
    }
}
