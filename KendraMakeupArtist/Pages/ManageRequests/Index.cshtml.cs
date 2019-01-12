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
    public class IndexModel : PageModel
    {
        private readonly KendraMakeupArtist.Data.ApplicationDbContext _context;

        public IndexModel(KendraMakeupArtist.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AppointmentRequest> AppointmentRequest { get;set; }

        public async Task OnGetAsync()
        {
            AppointmentRequest = await _context.AppointmentRequests.ToListAsync();
        }
    }
}
