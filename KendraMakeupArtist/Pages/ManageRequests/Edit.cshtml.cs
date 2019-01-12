using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KendraMakeupArtist.Data;
using KendraMakeupArtist.Models;

namespace KendraMakeupArtist.Pages.ManageRequests
{
    public class EditModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public EditModel(KendraMakeupArtist.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AppointmentRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppointmentRequestExists(AppointmentRequest.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AppointmentRequestExists(int id)
        {
            return _context.AppointmentRequests.Any(e => e.Id == id);
        }
    }
}
