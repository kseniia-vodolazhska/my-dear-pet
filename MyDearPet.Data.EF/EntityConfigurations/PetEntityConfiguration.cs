using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDearPet.Data.EF.Models;

namespace MyDearPet.Data.EF.EntityConfigurations
{
    public class PetEntityConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Gender).IsRequired();
            builder.Property(p => p.DateOfBirth).IsRequired();
            builder.HasOne(p => p.Curator);
            builder.HasOne(p => p.Shelter).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(p => p.Media);
        }
    }
}
