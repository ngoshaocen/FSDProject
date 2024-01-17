using FSDProject.Shared.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSDProject.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSDProject.Server.Configurations.Entities
{
    public class ConsultationSessionSeedConfiguration : IEntityTypeConfiguration<ConsultationSession>
    {
        public void Configure(EntityTypeBuilder<ConsultationSession> builder)
        {
            builder.HasData(
                new ConsultationSession
                {
                    Id = 1,
                    Name = "John Lim's Consultation",
                    CSessionDate = DateTime.Now.AddDays(7),
                    CSessionDetails = "1 Hour Consultation Session for Tim Loh.",
                    CSessionFee = 50,
                    CSessionType = "Online",
                    ConsultantID = 1,
                    JobSeekerID = 1
                },
                new ConsultationSession
                {
                    Id = 2,
                    Name = "Jane Tan's Consultation",
                    CSessionDate = DateTime.Now.AddDays(14),
                    CSessionDetails = "1 Hour Consultation Session For James Teo.",
                    CSessionFee = 75,
                    CSessionType = "In-Person",
                    ConsultantID = 2,
                    JobSeekerID = 2
                }
            );
        }
    }
}