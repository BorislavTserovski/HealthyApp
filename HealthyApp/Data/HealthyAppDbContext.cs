using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthyApp.Models;
using HealthyApp.Data.Models;

namespace HealthyApp.Data
{
    public class HealthyAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Diet> Diets { get; set; }
        

        public HealthyAppDbContext(DbContextOptions<HealthyAppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Diet>()
                .HasOne(d => d.Author)
                .WithMany(a => a.Diets)
                .HasForeignKey(d => d.AuthorId);

            base.OnModelCreating(builder);
            
        }
    }
}
