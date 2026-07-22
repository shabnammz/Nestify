namespace Nestify.Domain.Entities
{
    public class PropertyImage : BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool IsCover { get; set; }

        //relational
        public Guid PropertyId { get; set; }
        public Property? Property { get; set; }
    }
}
