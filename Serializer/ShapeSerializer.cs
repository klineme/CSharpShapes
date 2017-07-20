using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Serializer
{
    public static class ShapeSerializer
    {
        private static Type shapeType = typeof(ShapeDTO);
        private static MemoryStream stream = null;
        private static DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(shapeType);
        private static DataContractSerializer xmlSerializer = new DataContractSerializer(shapeType);
        private static ShapeDTO shape = null;

        public static string ShapeToJson(ShapeDTO data)
        {
            stream = new MemoryStream();
            //jsonSerializer = new DataContractJsonSerializer(typeof(ShapeDTO));
            jsonSerializer.WriteObject(stream, data);
            var serializedData = stream.ToArray();
            stream.Close();
            return Encoding.UTF8.GetString(serializedData);
        }
        public static ShapeDTO JsonToShape(string data)
        {
            using (stream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                shape = jsonSerializer.ReadObject(stream) as ShapeDTO;
            }
            return shape;
        }
    }
}
