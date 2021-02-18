using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAssignment.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.
                GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(

                    new Project
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        publisher = "Signet",
                        ISBN = "978-0451419429",
                        Classification = "Fiction, Classic",
                        Price = 9.95
                    },
                    new Project
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction, Biography",
                        Price = 14.58
                    },
                    new Project
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction, Biography",
                        Price = 21.54
                    },
                    new Project
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction, Biography",
                        Price = 11.61
                    },
                    new Project
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        publisher = "Random House",
                        ISBN = "978-9780812974492",
                        Classification = "Non-Fiction, Historical",
                        Price = 13.33
                    },
                    new Project
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction, Historical Fiction",
                        Price = 15.95
                    },
                    new Project
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction, Self-Help",
                        Price = 14.99
                    },
                    new Project
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction, Self-Help",
                        Price = 21.66
                    },
                    new Project
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction, Business",
                        Price = 29.16
                    },
                    new Project
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction, Thrillers",
                        Price = 15.03
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
