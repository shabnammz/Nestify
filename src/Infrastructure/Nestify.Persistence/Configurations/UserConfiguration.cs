using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestify.Domain.Entities;

namespace Nestify.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.Property(x => x.PasswordHash)
                .IsRequired();

            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(x => x.Role)
                .IsRequired()
                .HasConversion<string>();

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.Property(x => x.CreatedBy)
                .HasMaxLength(100);

            builder.Property(x => x.UpdatedBy)
                .HasMaxLength(100);

            builder.Property(x => x.DeletedBy)
                .HasMaxLength(100);

            // Relations
            builder.HasMany(x => x.Properties)
                .WithOne(x => x.Owner)
                .HasForeignKey(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Applications)
                .WithOne(x => x.Tenant)
                .HasForeignKey(x => x.TenantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.LandlordContracts)
                .WithOne(x => x.Landlord)
                .HasForeignKey(x => x.LandlordId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.TenantContracts)
                .WithOne(x => x.Tenant)
                .HasForeignKey(x => x.TenantId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Reviews)
                .WithOne(x => x.Reviewer)
                .HasForeignKey(x => x.ReviewerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Favorites)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.RefreshTokens)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
