using Nestify.Domain.Entities.Enums;

namespace Nestify.Domain.Entities
{
    public class User: SoftDeletableBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PhoneNumber { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }

        //relational
        public ICollection<Property> Properties { get; set; } = new List<Property>();
        public ICollection<Application> Applications { get; set; } = new List<Application>();
        public ICollection<Contract> LandlordContracts { get; set; } = new List<Contract>();
        public ICollection<Contract> TenantContracts { get; set; } = new List<Contract>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
