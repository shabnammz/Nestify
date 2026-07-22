namespace Nestify.Domain.Entities
{
    public class City:BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }

        //relational
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
