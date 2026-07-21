namespace Nestify.Domain.Entities
{
    public abstract class SoftDeletableBaseEntity:BaseEntityWithAudit
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? DeletedBy { get; set; }
    }
}
