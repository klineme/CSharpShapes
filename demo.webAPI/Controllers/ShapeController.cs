using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ConsoleApp.Shapes;
using System.Threading.Tasks;

namespace demo.webAPI.Controllers
{
    public class ShapeController : ApiController
    {
        List<Shape> shapes = new List<Shape>()
        {
            new Shape(1,2),
            new Shape(3,6),
            new Triangle(2, 3),
            new Shape(22, 33),
            new Shape(66, 66)
        };
        //api/Shape/
        [HttpGet]
        public IEnumerable<Shape> GetShapes()
        {
            return shapes;
        }
        [AcceptVerbs("GET")]
        public IHttpActionResult GetShape(int length)
        {
            Shape SH = shapes.FirstOrDefault(s => s.Length > length);
            return Ok(SH);
        }
        public IHttpActionResult PostShape(Shape data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            shapes.Add(data);
            return Ok<List<Shape>>(shapes);
        }
        public async Task<IHttpActionResult> GetShapeByTypeAsync(string type)
        {
            var result = await MockData.SelectShapesByType(type);
            return null;
        }
        [HttpDelete]
        [Route("api/Delete/{index}")]
        public IHttpActionResult DeleteShapeAtIndex(int index)
        {
            try
            {
                shapes.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                return BadRequest("Index is out of bounds");
            }
            return Ok(shapes);
        }
    }
}
