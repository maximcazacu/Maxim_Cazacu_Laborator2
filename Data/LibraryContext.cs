using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maxim_Cazacu_Laborator2.Models;

namespace Maxim_Cazacu_Laborator2.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Maxim_Cazacu_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Maxim_Cazacu_Laborator2.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Maxim_Cazacu_Laborator2.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Maxim_Cazacu_Laborator2.Models.Author> Authors { get; set; } = default!;

    }
}

