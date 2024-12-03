using System.Linq;
using Maxim_Cazacu_Laborator2.Models;
using Microsoft.EntityFrameworkCore;

namespace Maxim_Cazacu_Laborator2.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LibraryContext(
                serviceProvider.GetRequiredService<DbContextOptions<LibraryContext>>()))
            {
                if (context.Book.Any())
                {
                    return;   // BD a fost creată anterior
                }

                var authors = new[]
                {
                    new Author { FirstName = "Mihail", LastName = "Sadoveanu" },
                    new Author { FirstName = "George", LastName = "Călinescu" },
                    new Author { FirstName = "Mircea", LastName = "Eliade" }
                };

                context.Authors.AddRange(authors);

                var books = new[]
                {
                    new Book { Title = "Baltagul", Author = authors[0], Price = Decimal.Parse("22") },
                    new Book { Title = "Enigma Otiliei", Author = authors[1], Price = Decimal.Parse("18") },
                    new Book { Title = "Maytrei", Author = authors[2], Price = Decimal.Parse("27") }
                };

                context.Book.AddRange(books);

                context.Genre.AddRange(
                    new Genre { Name = "Roman" },
                    new Genre { Name = "Nuvela" },
                    new Genre { Name = "Poezie" }
                );

                context.Customer.AddRange(
                    new Customer
                    {
                        Name = "Popescu Marcela",
                        Adress = "Str. Plopilor, nr. 24",
                        BirthDate = DateTime.Parse("1979-09-01")
                    },
                    new Customer
                    {
                        Name = "Mihailescu Cornel",
                        Adress = "Str. București, nr. 45, ap. 2",
                        BirthDate = DateTime.Parse("1969-07-08")
                    }
                );

                context.SaveChanges();
            }
        }
    }
}

