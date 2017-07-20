using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serializer
{
    [DataContract]
    public class ShapeDTO
    {
        [DataMember]
        public int length = 0;
        [DataMember]
        public int width { get; set; }

        public ShapeDTO()
        {

        }
        public ShapeDTO(int l, int w)
        {
            length = l;
            width = w;
        }
    }
}
