using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestify.Domain.Entities
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }

        //relational
        public ICollection<Property> Properties { get; set; }
    }
}
