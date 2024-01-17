using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class Consultant : BaseDomainModel
    {
        public string? ConsName { get; set; }
        public string? ConsPhone { get; set; }
        public string? ConsEmail { get; set;}
        public string? ConsEducation { get; set; }
        public string? ConsIndustry { get; set; }
        public string? ConsExperience { get; set; }
        public string? ConsDescription { get; set; }
        public virtual List<ConsultationSession>? ConsultationSessions { get; set; }
    }
}
