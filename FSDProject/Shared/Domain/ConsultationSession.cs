using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSDProject.Shared.Domain
{
    public class ConsultationSession : BaseDomainModel, IValidatableObject
    {
        [Required]
        public string? Name { get; set; }
		[Required]

		public DateTime CSessionDate { get; set; }
		[Required]

		public string? CSessionDetails { get; set; }
		[Required]
        [DataType(DataType.Currency)]
        public int CSessionFee { get; set; }

		public string? CSessionType { get; set; }

        public int? ConsultantID { get; set; }

        public virtual Consultant? Consultant { get; set; }

        public int? JobSeekerID { get; set; }

        public virtual JobSeeker? JobSeeker { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
            if (CSessionDate != null)
            {
                if (CSessionDate <= DateTime.Now)
                {
                    yield return new ValidationResult("Consultation Session Date must be greater than current date ", new[] { "CSessionDate" });
                }
            }
		}
	}
}