using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDearPet.Data.EF.Models;

namespace MyDearPet.Data.EF.EntityConfigurations
{
    public class LocationEntityConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id).ValueGeneratedOnAdd();
            builder.Property(l => l.Name).HasMaxLength(20).IsRequired();
            builder.Property(l => l.Address).HasMaxLength(30).IsRequired();
            builder.Property(l => l.City).HasMaxLength(10).IsRequired();
            builder.Property(l => l.CountryCode).HasMaxLength(10).IsRequired();
            builder.Property(l => l.PhoneNumber).HasMaxLength(20).IsRequired();
            builder.Property(l => l.PostalCode).HasMaxLength(10).IsRequired();
        }
    }
}
