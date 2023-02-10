using Bookstore.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    
        public DbSet<Book> Books { get; set; }
        public DbSet<Bookstore.Models.BookCreateViewModel> DogCreateViewModel { get; set; }

        public DbSet<Bookstore.Models.BookDetailsViewModel> BookDetailsViewModel { get; set; }
    }
}
