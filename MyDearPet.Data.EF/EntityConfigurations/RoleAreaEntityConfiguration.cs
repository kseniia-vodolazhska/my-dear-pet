using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDearPet.Data.EF.Models;

namespace MyDearPet.Data.EF.EntityConfigurations
{
    public class RoleAreaEntityConfiguration : IEntityTypeConfiguration<RoleArea>
    {
        public void Configure(EntityTypeBuilder<RoleArea> builder)
        {
            builder.HasKey(ra => new { ra.RoleId, ra.AreaId });
        }
    }
}
