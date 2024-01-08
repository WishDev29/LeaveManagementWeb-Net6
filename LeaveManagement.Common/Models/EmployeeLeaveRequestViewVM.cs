namespace LeaveManagement.Common.Models
{
    public class EmployeeLeaveRequestViewVM
    {
        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> leaveAllocationVMs, List<LeaveRequestVM> leaveRequests)
        {
            LeaveAllocations = leaveAllocationVMs;
            LeaveRequests = leaveRequests;
        }

        public List<LeaveAllocationVM> LeaveAllocations { get; set; }

        public List<LeaveRequestVM> LeaveRequests { get; set; }
    }
}
