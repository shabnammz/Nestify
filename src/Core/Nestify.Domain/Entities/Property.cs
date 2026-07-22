

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
        public Category? Category { get; set; }
        public Guid CityId { get; set; }
        public City? City { get; set; }
        public Guid OwnerId { get; set; }
        public User? Owner { get; set; }

        public ICollection<PropertyImage> Images { get; set; } = new List<PropertyImage>();
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}
