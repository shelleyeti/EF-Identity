using System;
using System.Collections.Generic;
using System.Text;
using IdentityApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            DbSet<ApplicationUser> ApplicationUsers { get; set; }
            public DbSet<IdentityApp.Models.Product> Product { get; set; }
    }
}
