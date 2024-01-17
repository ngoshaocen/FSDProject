using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSDProject.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "525e0c01-8777-45bb-97a8-7487b6267ca1",
                Name = "Consultant",
                NormalizedName = "CONSULTANT"
            },
            new IdentityRole
            {
                Id = "ce0d9f29-087e-469c-b766-95c6fcad87a6",
                Name = "Staff",
                NormalizedName = "STAFF"
            },
            new IdentityRole
            {
                Id = "f0d990b3-8ae8-4357-a62b-5c4380685ce1b",
                Name = "JobSeeker",
                NormalizedName = "JOBSEEKER"
            }
            );
        }
    }
}