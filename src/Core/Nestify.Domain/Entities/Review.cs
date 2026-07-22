namespace Nestify.Domain.Entities
{
    public class Review : BaseEntityWithAudit
    {
        public int Rating { get; set; }
        public string Comment { get; set; }

        //relational
        public Guid ReviewerId { get; set; }
        public User? Reviewer { get; set; }
        public Guid PropertyId { get; set; }
        public Property? Property { get; set; }
    }
}
