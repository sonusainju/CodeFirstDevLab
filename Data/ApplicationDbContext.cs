using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CodeFirstDevLab.Models;

namespace CodeFirstDevLab.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }
        public DbSet<CodeFirstDevLab.Models.Province> Province { get; set; }
        public DbSet<CodeFirstDevLab.Models.City> City { get; set; }
    }
}
