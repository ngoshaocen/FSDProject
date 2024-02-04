using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class JobSeeker : BaseDomainModel
    {
        [Required]
        public string? JSName { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string? JSEmail { get; set;}
		[Required]
		[DataType(DataType.PhoneNumber)]
		public string? JSPhone { get; set;}
        public string? JSIndustryPreference { get; set;}
        public string? JSJobPreference { get; set;}
		[Required]
		public string? JSEmploymentStatus { get; set;}
		[Required]
		public string? JSDescription { get; set;}
		[Required]
		public string? JSEducation { get; set; }
        public virtual List<ConsultationSession>? ConsultationSessions { get; set;}
    }
}
