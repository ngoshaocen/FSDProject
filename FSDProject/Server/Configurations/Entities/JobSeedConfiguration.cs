using FSDProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Server.Configurations.Entities
{
    public class JobSeedConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(
                new Job
                {
                    Id = 1,
                    JobTitle = "Software Engineer",
                    JobSalary = "110000",
                    JobEducation = "Expert proficiency in SQL & any popular backend languages e.g Python, Javascript/Typescript, Go etc",
                    JobDescription = "You will be working on our clients project that will involve building out the founding Engineering team based in Singapore. This is a Backend Engineer position that is data-focused. This is a unique position given that you will have the opportunity to work on the backend to the entire ELT data pipeline for our client and at the same time be working closely with customers to understand their needs.",
                    JobCategory = "Engineering",
                    JobLevel = "Advisor",
                    JobLocation = "Tampines",
                    JobDeadline = new DateTime(2023, 1, 19)
                },
                new Job
                {
                    Id = 2,
                    JobTitle = "Software Engineer (AI Verify)",
                    JobSalary = "120000",
                    JobEducation = "Proficient with CI/CD tools and concepts, such as Lint, PyTest, and automated build and test approaches. Knowledge of security IAST and SCA tools is a plus",
                    JobDescription = "Manage the open source repositories, ensuring all codes are properly structured, tagged, and are in working order. Create, track, manage, and engage the community on issues relating to the codebase, including bugs and feature requests.",
                    JobCategory = "Engineering",
                    JobLevel = "Employee",
                    JobLocation = "Pasir Panjang",
                    JobDeadline = new DateTime(2023, 2, 12)
                }
                );
        }
    }
}
