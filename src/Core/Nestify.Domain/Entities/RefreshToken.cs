namespace Nestify.Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime CreatedAt { get; set; }

        //relational
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
