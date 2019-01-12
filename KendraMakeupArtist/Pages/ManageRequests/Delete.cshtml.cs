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
    public class DeleteModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public DeleteModel(KendraMakeupArtist.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AppointmentRequest = await _context.AppointmentRequests.FindAsync(id);

            if (AppointmentRequest != null)
            {
                _context.AppointmentRequests.Remove(AppointmentRequest);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
