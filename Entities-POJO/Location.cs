using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Location:BaseEntity
    {
        public string IdLocation { get; set; }
        public string LocationType { get; set; }
        public string Value { get; set; }
        public string CustomerId { get; set; }
    }
}
