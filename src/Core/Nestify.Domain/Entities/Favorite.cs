namespace Nestify.Domain.Entities
{
    public class Favorite : BaseEntity
    {
        public DateTime SavedAt { get; set; }

        //relational
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid PropertyId { get; set; }
        public Property? Property { get; set; }
    }
}
