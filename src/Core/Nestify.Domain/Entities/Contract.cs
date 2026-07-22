using Nestify.Domain.Entities.Enums;

namespace Nestify.Domain.Entities
{
    public class Contract : SoftDeletableBaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MonthlyRent { get; set; }
        public ContractStatus Status { get; set; }
        public string? FilePath { get; set; }

        //relational
        public Guid ApplicationId { get; set; }
        public Application? Application { get; set; }
        public Guid LandlordId { get; set; }
        public User? Landlord { get; set; }
        public Guid TenantId { get; set; }
        public User? Tenant { get; set; }
    }
}
