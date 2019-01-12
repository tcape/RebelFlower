using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KendraMakeupArtist.Data;
using KendraMakeupArtist.Models;

namespace KendraMakeupArtist.Pages.ManageRequests
{
    public class CreateModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public CreateModel(KendraMakeupArtist.Data.ApplicationDbContext context)
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

            _context.AppointmentRequests.Add(AppointmentRequest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}