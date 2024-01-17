using FSDProject.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSDProject.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "staff@localhost.com",
                NormalizedEmail = "STAFF@LOCALHOST.COM",
                FirstName = "Staff",
                LastName = "User",
                UserName = "staff@localhost.com",
                NormalizedUserName = "staff@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1")
            }
            );
        }
    }
}