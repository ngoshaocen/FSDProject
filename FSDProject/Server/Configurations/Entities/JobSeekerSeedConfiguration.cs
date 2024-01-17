using FSDProject.Shared.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSDProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Server.Configurations.Entities
{
    public class JobSeekerSeedConfiguration : IEntityTypeConfiguration<JobSeeker>
    {
        public void Configure(EntityTypeBuilder<JobSeeker> builder)
        {
            builder.HasData(
                 new JobSeeker
                 {
                     Id = 1,
                     JSName = "Tim Loh",
                     JSPhone = "12341234",
                     JSEmail = "timloh@gmail.com",
                     JSIndustryPreference = "Engineering",
                     JSJobPreference = "Software Engineer",
                     JSEducation = "Diploma in Computer Engineering",
                     JSEmploymentStatus = " Unemployed",
                     JSDescription = "TP Computer Engineering Graduate."
                 },
                 new JobSeeker
                 {
                     Id = 2,
                     JSName = "James Teo",
                     JSPhone = "56785678",
                     JSEmail = "jamesteo@gmail.com",
                     JSIndustryPreference = "IT",
                     JSJobPreference = "IOT Security",
                     JSEducation = "Diploma in CyberSecurity",
                     JSEmploymentStatus = " Employed",
                     JSDescription = "TP Graduate. Currently working for XXX company."
                 }
             );
        }
    }
}
