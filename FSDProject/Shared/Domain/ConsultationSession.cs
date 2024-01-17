using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class ConsultationSession : BaseDomainModel
    {
        public string? Name { get; set; }
        public DateTime CSessionDate { get; set; }
        public string? CSessionDetails { get; set; }
        public int CSessionFee { get; set; }
        public string? CSessionType { get; set; }
        public int ConsultantID { get; set; }
        public virtual Consultant? Consultant { get; set; }
        public int JobSeekerID { get; set; }
        public virtual JobSeeker? JobSeeker { get; set; }
    }
}
