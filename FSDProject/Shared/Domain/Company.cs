using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class Company : BaseDomainModel
    {
        public string? CompanyName { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactNumber { get; set; }
        public string? ContactEmail { get; set; }
        public string? CompanyDescription { get; set; }
        public string? CompanyIndustry { get; set; }
        public string? CompanyLocation { get; set; }
        public string? CompanyWebsite { get; set; }
        public string? CompanyFoundedYear { get; set; }
    }
}
