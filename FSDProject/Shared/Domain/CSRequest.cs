using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace FSDProject.Shared.Domain
    {
    public class CSRequest : BaseDomainModel
    {
        public int Id { get; set; }
        [Required]
        public string? RequestMessage { get; set; }
        [Required]
        public DateTime RequestDate { get; set; }
        public RequestStatus Status { get; set; }
        public int? ConsultantID { get; set; }
        public virtual Consultant? Consultant { get; set; }
        public int? JobSeekerID { get; set; }
        public virtual JobSeeker? JobSeeker { get; set; }
    }

    public enum RequestStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}