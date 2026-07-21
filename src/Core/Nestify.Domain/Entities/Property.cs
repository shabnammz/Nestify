using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Nestify.Domain.Entities
{
    public class Property : SoftDeletableBaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Rooms { get; set; }
        public float Area { get; set; }
        public string Address { get; set; }
        public bool IsAvailable { get; set; }

        // relational
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid CityId { get; set; }
        public City City { get; set; }
    }
}
