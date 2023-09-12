using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UdemyProj1.ViewModels
{
    public class LeaveTypeVM
    {
        public int Id { get; set; } 
        public string? Name { get; set; }

        [Display(Name = "Number of days")]
        public int DefaultDays { get; set; }
    }
}
