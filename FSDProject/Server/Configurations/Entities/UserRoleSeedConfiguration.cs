using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration :
    IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "ce0d9f29-087e-469c-b766-95c6fcad87a6",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
            }
            );

            builder.HasData(
           new IdentityUserRole<string>
           {
               RoleId = "525e0c01-8777-45bb-97a8-7487b6267ca1",
               UserId = "c8090b62-0e8c-4631-a3fb-717ebe2a55ab"
           }
           );
        }
    }
}