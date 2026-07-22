using Nestify.Domain.Entities.Enums;

namespace Nestify.Domain.Entities
{
    public class Application:SoftDeletableBaseEntity
    {
        public ApplicationStatus Status { get; set; }
        public string Message { get; set; }

        //relational
        public Guid TenantId { get; set; }
        public User? Tenant { get; set; }
        public Guid PropertyId { get; set; }
        public Property? Property { get; set; }
        public Contract? Contract { get; set; }
    }
}
