using System.ComponentModel.DataAnnotations;

namespace UdemyProj1.Models
{
    public class LeaveType : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public int DefaultDays { get; set; }
       
    }
}
