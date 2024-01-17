using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class JobSeeker : BaseDomainModel
    {
        public string? JSName { get; set; }
        public string? JSEmail { get; set;}
        public string? JSPhone { get; set;}
        public string? JSIndustryPreference { get; set;}
        public string? JSJobPreference { get; set;}
        public string? JSEmploymentStatus { get; set;}
        public string? JSDescription { get; set;}
        public string? JSEducation { get; set; }
        public virtual List<ConsultationSession>? ConsultationSessions { get; set;}
    }
}
