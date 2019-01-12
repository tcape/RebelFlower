using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KendraMakeupArtist.Models
{
    public class UserAppointmentRequest
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("AppointmentRequest")]
        public int AppointmentRequestId { get; set; }
        public AppointmentRequest AppointmentRequest { get; set; }


    }
}
