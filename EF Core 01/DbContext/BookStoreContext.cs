using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_01.DbContext
{
    using EF_Core_01.Entities;
    // Question 4
    // Create DbContext class using EF Core Conventions

    using Microsoft.EntityFrameworkCore;

    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;
              Database=ReadMoreBooksDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;"
            );
        }
    }
}






