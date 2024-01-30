using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class Job : BaseDomainModel
    {
        public string? JobTitle { get; set; }
        public string? JobSalary { get; set; }
        public string? JobEducation { get; set; }
        public string? JobDescription { get; set; }
        public string? JobCategory { get; set; }
        public string? JobLevel { get; set; }
        public string? JobLocation { get; set; }
        public DateTime? JobDeadline { get; set; }
        public int? CompanyID { get; set; }
        public virtual Company? Company { get; set; }
        public int? StaffID { get; set; }
        public virtual Staff? Staff { get; set; }

    }
}
