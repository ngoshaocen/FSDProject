using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProject.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffName { get; set; }
        public string? StaffUsername { get ; set; }
        public string? StaffPassword { get; set; }
        public string? StaffPosition { get; set; }
        public string? StaffEmail { get; set; }
        public DateTime StaffDateOfHire { get; set; }
        public string? StaffAddress { get; set; }
    }
}
