using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KendraMakeupArtist.Models
{
    public enum UserType { Customer, Administrator };
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public UserType UserType { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        public string LastName { get; set; }

        public ICollection<UserAppointmentRequest> UserAppointmentRequests { get; set; } = new List<UserAppointmentRequest>();
    }
}
