using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nestify.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //relational
        public ICollection<Property> Properties { get; set; }
    }
}
