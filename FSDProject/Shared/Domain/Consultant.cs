using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FSDProject.Shared.Domain
{
    public class Consultant : BaseDomainModel
    {
        public int Id { get; set; }

        [Required]
        public string? ConsName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? ConsPhone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? ConsEmail { get; set; }

        [Required]
        public string? ConsEducation { get; set; }

        [Required]
        public string? ConsIndustry { get; set; }

        [Required]
        public string? ConsExperience { get; set; }

        [Required]
        public string? ConsDescription { get; set; }

        public virtual List<ConsultationSession>? ConsultationSessions { get; set; }
    }
}