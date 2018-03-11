using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDearPet.Data.EF.Models;

namespace MyDearPet.Data.EF.EntityConfigurations
{
    public class ShelterEntityConfiguration : IEntityTypeConfiguration<Shelter>
    {
        public void Configure(EntityTypeBuilder<Shelter> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();
            builder.Property(s => s.Title).HasMaxLength(30).IsRequired();
            builder.Property(s => s.Description).HasMaxLength(50).IsRequired();
            builder.HasOne(s => s.Owner);
            builder.HasOne(s => s.Location);
            builder.HasMany(s => s.Media);
        }
    }
}
