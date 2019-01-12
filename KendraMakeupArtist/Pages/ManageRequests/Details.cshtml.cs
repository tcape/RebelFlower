using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KendraMakeupArtist.Data;
using KendraMakeupArtist.Models;

namespace KendraMakeupArtist.Pages.ManageRequests
{
    public class DetailsModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public DetailsModel(KendraMakeupArtist.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public AppointmentRequest AppointmentRequest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppointmentRequest = await _context.AppointmentRequests.FirstOrDefaultAsync(m => m.Id == id);

            if (AppointmentRequest == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
