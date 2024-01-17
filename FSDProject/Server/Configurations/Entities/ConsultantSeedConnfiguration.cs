using FSDProject.Shared.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSDProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Server.Configurations.Entities
{
        public class ConsultantSeedConfiguration : IEntityTypeConfiguration<Consultant>
    {
        public void Configure(EntityTypeBuilder<Consultant> builder)
        {
            builder.HasData(
                 new Consultant
                 {
                     Id = 1,
                     ConsName = "John Lim",
                     ConsPhone = "12345678",
                     ConsEmail = "johnlim@gmail.com",
                     ConsEducation = "Ph.D in Computer Science",
                     ConsIndustry = "Technology",
                     ConsExperience = "5 years",
                     ConsDescription = "Experienced consultant in technology industry."
                 },
                 new Consultant
                 {
                     Id = 2,
                     ConsName = "Jane Tan",
                     ConsPhone = "12345678",
                     ConsEmail = "janetan@gmail.com",
                     ConsEducation = "Ph.D. in Business",
                     ConsIndustry = "Finance",
                     ConsExperience = "8 years",
                     ConsDescription = "Finance consultant with a Ph.D. in Business."
                 }
             );
        }
    }
}
