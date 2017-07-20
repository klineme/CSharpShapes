using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConsoleApp.Shapes;
using System.Threading.Tasks;

namespace demo.webAPI
{
    public static class MockData
    {
        public static List<Shape> shapelist = new List<Shape>()
        {
            new Shape(1,2),
            new Shape(3,6),
            new Shape(2, 3),
            new Shape(22, 33),
            new Shape(66, 66)
        };

        public static async Task<List<Shape>> SelectShapesByType(string type)
        {
            var result = await Task.Run(() => shapelist.Where(s => s.GetType().Name == type).ToList());
            return result;
        }
    }
}