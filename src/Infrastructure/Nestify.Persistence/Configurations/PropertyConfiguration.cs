using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nestify.Domain.Entities;

namespace Nestify.Persistence.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.ToTable("Properties");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(x => x.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.Rooms)
                .IsRequired();

            builder.Property(x => x.Area)
                .IsRequired()
                .HasColumnType("float");

            builder.Property(x => x.Address)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(x => x.IsAvailable)
                .HasDefaultValue(true);

            builder.Property(x => x.CreatedBy)
                .HasMaxLength(100);

            builder.Property(x => x.UpdatedBy)
                .HasMaxLength(100);

            builder.Property(x => x.DeletedBy)
                .HasMaxLength(100);

            // Relations
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Properties)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.City)
                .WithMany(x => x.Properties)
                .HasForeignKey(x => x.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Images)
                .WithOne(x => x.Property)
                .HasForeignKey(x => x.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Applications)
                .WithOne(x => x.Property)
                .HasForeignKey(x => x.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Reviews)
                .WithOne(x => x.Property)
                .HasForeignKey(x => x.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Favorites)
                .WithOne(x => x.Property)
                .HasForeignKey(x => x.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
