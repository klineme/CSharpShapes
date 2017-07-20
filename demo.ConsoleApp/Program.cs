using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Shapes;
using Serializer;

namespace demo.ConsoleApp
{
    class Program
    {
        //Private

        static void Main(string[] args)
        {
            ShapeDTO dto = new ShapeDTO(2, 3);
            string jsonstring = ShapeSerializer.ShapeToJson(dto);
            Console.WriteLine($"Serialized to json\n{jsonstring}");

            var output = ShapeSerializer.JsonToShape(jsonstring);
            Shape s = new Shape(output.length, output.width);
            List<Shape> shapes = new List<Shape>();

            for(int i = 1; i < 101; i++)
            {
                if (i % 5 == 0)
                    shapes.Add(new Triangle(i, i * 3));
                else
                    shapes.Add(new Rectangle(i, i));
            }
            //var bigArea = shapes.Where(s => s.Area() > 25).ToList();
           // var rectangles = shapes.Where(s => s is Rectangle).ToList();
            //Circle c = Circle.GetCircle;
            //c.Radius = 555;
            //foreach (var item in bigArea)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine(c.Area());
            //Console.ReadLine();
        }
    }
}
