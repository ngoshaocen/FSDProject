using FSDProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject.Server.Configurations.Entities
{
    public class CompanySeedConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = 1,
                    CompanyName = "Nvidia Corporation",
                    ContactPerson = null,
                    ContactNumber = null,
                    ContactEmail = null,
                    CompanyDescription = "NVIDIA pioneered accelerated computing to tackle challenges no one else can solve. Our work in AI and digital twins is transforming the world's largest industries and profoundly impacting society.",
                    CompanyIndustry = "Consumer electronics",
                    CompanyLocation = "Santa Clara, California, U.S.",
                    CompanyWebsite = "www.nvidia.com",
                    CompanyFoundedYear = "05/04/1993"
                },
                new Company
                {
                    Id = 2,
                    CompanyName = "InfoCommunications Media Development Authority",
                    ContactPerson = null,
                    ContactNumber = null,
                    ContactEmail = null,
                    CompanyDescription = "IMDA is a driving force behind Singapore's digital transformation efforts by building the foundations of its digital infrastructure and driving digital innovation for a vibrant digital workforce and a safe and inclusive digital society that can thrive in today's fast-evolving digital landscape in Singapore.",
                    CompanyIndustry = "Infocomm and Media",
                    CompanyLocation = "10 Pasir Panjang Road, #03-01, Mapletree Business City, Singapore 117438",
                    CompanyWebsite = "www.imda.gov.sg",
                    CompanyFoundedYear = "01/10/2016"
                }
                );
        }
    }
}
