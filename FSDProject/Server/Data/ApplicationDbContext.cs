using Duende.IdentityServer.EntityFramework.Options;
using FSDProject.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FSDProject.Shared.Domain;
using FSDProject.Server.Configurations.Entities;
using System.Reflection.Emit;
using CarRentalManagement.Server.Configurations.Entities;

namespace FSDProject.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<ConsultationSession> ConsultationSessions { get; set; }
        public DbSet<CSRequest> CSRequests { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new ConsultantSeedConfiguration());
            builder.ApplyConfiguration(new JobSeekerSeedConfiguration());
            builder.ApplyConfiguration(new ConsultationSessionSeedConfiguration());
        }
    }
}