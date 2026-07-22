namespace Nestify.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }

        //relational
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }
}
