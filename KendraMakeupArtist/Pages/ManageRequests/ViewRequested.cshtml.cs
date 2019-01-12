using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KendraMakeupArtist.Data;
using KendraMakeupArtist.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace KendraMakeupArtist.Pages.ManageRequests
{
    public class ViewRequestedModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public ViewRequestedModel(KendraMakeupArtist.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ApplicationUser CurrentApplicationUser { get; set; }

        [BindProperty]
        public IList<AppointmentRequest> AppointmentRequests { get; set; }

        [BindProperty]
        public int count { get; set; }

        //public IActionResult OnGet()
        //{
        //    AppointmentRequests = _context.AppointmentRequests.Where(r => r.AppointmentType.Equals(0)).ToArray();
        //    //if (!User.Identity.IsAuthenticated)
        //    //    return RedirectToPage("/Index");

        //    //var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        //    //if (currentUserId.Equals(null))
        //    //{
        //    //    return RedirectToPage("/Index");
        //    //}

        //    //else if (CurrentApplicationUser.UserType.Equals(1))
        //    //{
        //    //    AppointmentRequests = _context.AppointmentRequests.Where(r => r.AppointmentType.Equals(0)).ToArray();
        //    //}

        //    return Page();
        //}

        public async Task OnGetAsync()
        {
            //var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //CurrentApplicationUser = _context.ApplicationUsers.Where(u => u.Id == currentUserId).FirstOrDefault();

            //if (CurrentApplicationUser.UserType.Equals(1))
            //{
            //    AppointmentRequests = await _context.AppointmentRequests.Where(r => r.AppointmentType.Equals(0)).ToArrayAsync(); 
            //}
            AppointmentRequests = await _context.AppointmentRequests.Where(r => r.RequestStatus == 0).ToArrayAsync();
            count = AppointmentRequests.Count();
        }

        

        public async Task<IActionResult> OnPostAsync()
        {
            for (int i = 0; i < AppointmentRequests.Count; i++)
            {
                _context.AppointmentRequests.ToArray()[i].RequestStatus = AppointmentRequests[i].RequestStatus;
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}