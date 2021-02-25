using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<Image> Image { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}
