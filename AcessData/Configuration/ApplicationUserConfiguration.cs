using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
namespace AccessData.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // Configure the ApplicationUser entity
            builder.Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName)
                .IsRequired()
                .HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail)
                .IsRequired()
                .HasMaxLength(256);
        }
    }
}
