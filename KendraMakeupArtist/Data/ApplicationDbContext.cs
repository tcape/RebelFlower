using System;
using System.Collections.Generic;
using System.Text;
using KendraMakeupArtist.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KendraMakeupArtist.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<AppointmentRequest> AppointmentRequests { get; set; }

        public DbSet<UserAppointmentRequest> UserAppointmentRequests { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
