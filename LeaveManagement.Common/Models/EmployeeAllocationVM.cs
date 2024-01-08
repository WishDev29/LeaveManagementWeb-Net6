using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Common.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public string Id { get; set; }

        [Display(Name = "First Name")]
        public string? Firstname { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Date Joined")]
        public string? DateJoined { get; set; }

        [Display(Name = "Email Address")]
        public string? Email { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
