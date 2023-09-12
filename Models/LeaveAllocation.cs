using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyProj1.Models
{
    public class LeaveAllocation : BaseEntity
    { 
        public int NumberOfDays { get; set; }

        //foreign key of leaveType class
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        //reference of employee table 
        public string EmployeeId { get; set; }  

    }
}
