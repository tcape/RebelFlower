using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KendraMakeupArtist.Models
{
    public enum AppointmentType { Training, Individual, Wedding, Editorial, Other };

    public enum RequestStatus { Requested, Denied, Approved, Confirmed };

    public class AppointmentRequest
    {
        [Key]
        public int Id { get; set; }

        public RequestStatus RequestStatus { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Type of Service")]
        public AppointmentType AppointmentType { get; set; }

        // auto generate DateTime.Now
        [DataType(DataType.DateTime)]
        public DateTime RequestDateTime { get; set; } 

        [Required]
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }


        [Required]
        [Display(Name = "Location (Venue, Address)")]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }

        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhone { get; set; }
        
        [Required]
        [Display(Name = "Message (Please tell me about your event!)")]
        [DataType(DataType.MultilineText)]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        public string Message { get; set; }
    }
}
