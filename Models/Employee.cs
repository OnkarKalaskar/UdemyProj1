using Microsoft.AspNetCore.Identity;

namespace UdemyProj1.Models
{
    public class Employee : IdentityUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int TaxId { get; set; }
    }
}
