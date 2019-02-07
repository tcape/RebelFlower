using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KendraMakeupArtist.Data;
using System.Net.Mail;
using KendraMakeupArtist.Models;
using System.Text;
using System.Net;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace KendraMakeupArtist.Pages.Contact
{
    public class ContactModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public ContactModel(KendraMakeupArtist.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AppointmentRequest AppointmentRequest { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int type = Convert.ToInt32((Request.Form["ServiceType"]));
            
            var newAppointmentRequest = new AppointmentRequest
            {
                AppointmentDate = AppointmentRequest.AppointmentDate,
                AppointmentType = (AppointmentType)type,
                ContactEmail = AppointmentRequest.ContactEmail,
                ContactPhone = AppointmentRequest.ContactPhone,
                FirstName = AppointmentRequest.FirstName,
                LastName = AppointmentRequest.LastName,
                Location = AppointmentRequest.Location,
                Message = AppointmentRequest.Message,
                RequestDateTime = DateTime.Now,
                RequestStatus = RequestStatus.Requested
            };

            GenerateEmail(newAppointmentRequest);

            _context.AppointmentRequests.Add(newAppointmentRequest);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        public void GenerateEmail(AppointmentRequest newAppointmentRequest)
        {
            var emailString = new StringBuilder();
            emailString.Append("\nNew Service Request\n\n");
            emailString.Append("\n\nName:\t\t" + newAppointmentRequest.FirstName + " " + newAppointmentRequest.LastName);
            emailString.Append("\n\nService Type:\t" + newAppointmentRequest.AppointmentType.ToString());
            emailString.Append("\n\nEvent Date:\t" + newAppointmentRequest.AppointmentDate.ToString("dddd, MMMM dd yyyy"));
            emailString.Append("\n\nLocation:\t" + newAppointmentRequest.Location);
            emailString.Append("\n\nEmail:\t\t" + newAppointmentRequest.ContactEmail.ToString());
            emailString.Append("\n\nPhone:\t\t" + newAppointmentRequest.ContactPhone.ToString());
            emailString.Append("\n\nMessage:\n\n" + newAppointmentRequest.Message);

            var message = new MailMessage()
            {
                From = new MailAddress(newAppointmentRequest.ContactEmail.ToString()),
                Subject = "New Service Request",
                Body = emailString.ToString(),
                IsBodyHtml = false
            };
           
            message.To.Add(new MailAddress("rebelflowerartistry@gmail.com"));

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
			UserName = "",
                    	Password = ""
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
}
