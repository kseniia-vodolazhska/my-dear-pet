using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyDearPet.Data.EF.Models;

namespace MyDearPet.Data.EF.EntityConfigurations
{
    public class MessageEntityConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();
            builder.Property(m => m.Text).HasMaxLength(200).IsRequired();
            builder.HasOne(m => m.Sender).WithMany().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(m => m.Recepient).WithMany().OnDelete(DeleteBehavior.Restrict);
        }
    }
}
