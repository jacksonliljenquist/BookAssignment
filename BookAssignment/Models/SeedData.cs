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
                        Price = 9.95,
                        NumPages = 1488,
                        WebLink = "https://www.amazon.com/Miserables-Signet-Classics-Victor-Hugo/dp/" +
                        "045141943X/ref=sr_1_3?crid=1049W6P6OYXR1&dchild=1&keywords=les+miserables+" +
                        "book&qid=1614217276&sprefix=les+miserab%2Caps%2C208&sr=8-3"
                    },
                    new Project
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction, Biography",
                        Price = 14.58,
                        NumPages = 944,
                        WebLink = "https://www.amazon.com/Team-Of-Rivals/dp/B00BAR0IMC/ref=sr_1_" +
                        "3?crid=3P5TFY70Y3VOU&dchild=1&keywords=team+of+rivals&qid=1614217568&s" +
                        "prefix=Team+of+Ri%2Caps%2C214&sr=8-3"
                    },
                    new Project
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction, Biography",
                        Price = 21.54,
                        NumPages = 832,
                        WebLink = "https://www.amazon.com/Snowball-Warren-Buffett-Business-Life/dp/" +
                        "0553384619/ref=sr_1_1?keywords=the+snowball&qid=1614217680&sr=8-1"
                    },
                    new Project
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction, Biography",
                        Price = 11.61,
                        NumPages = 864,
                        WebLink = "https://www.amazon.com/American-Ulysses-Life-S-Grant/dp/" +
                        "1400069025/ref=sr_1_1?keywords=American+Ulysses&qid=1614217715&sr=8-1"
                    },
                    new Project
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        publisher = "Random House",
                        ISBN = "978-9780812974492",
                        Classification = "Non-Fiction, Historical",
                        Price = 13.33,
                        NumPages = 528,
                        WebLink = "https://www.amazon.com/Unbroken-Young-Adult-Adaptation-Olympians/dp/" +
                        "0385742525/ref=sr_1_2?dchild=1&keywords=unbroken&qid=1614217749&sr=8-2"
                    },
                    new Project
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction, Historical Fiction",
                        Price = 15.95,
                        NumPages = 288,
                        WebLink = "https://www.amazon.com/Great-Train-Robbery-Michael-Crichton/dp/" +
                        "0804171289/ref=sr_1_2?crid=4X0GRG1ALMPW&keywords=the+great+train+robbery&" +
                        "qid=1614218053&sprefix=the+great+train+robber%2Caps%2C200&sr=8-2"
                    },
                    new Project
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction, Self-Help",
                        Price = 14.99,
                        NumPages = 304,
                        WebLink = "https://www.amazon.com/Deep-Work-Focused-Success-Distracted/dp/" +
                        "1455586692/ref=sr_1_1?dchild=1&keywords=deep+work&qid=1614218098&sr=8-1"
                    },
                    new Project
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction, Self-Help",
                        Price = 21.66,
                        NumPages = 240,
                        WebLink = "https://www.amazon.com/Its-Your-Ship-Management-Anniversary/dp/" +
                        "145552302X/ref=sr_1_1?dchild=1&keywords=Its+your+ship&qid=1614218130&sr=8-1"
                    },
                    new Project
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction, Business",
                        Price = 29.16,
                        NumPages = 400,
                        WebLink = "https://www.amazon.com/Virgin-Way-Its-Worth-Doing/dp/" +
                        "1591847982/ref=sr_1_1?dchild=1&keywords=The+virgin+way&qid=1614218160&sr=8-1"
                    },
                    new Project
                    {
                        Title = "Sycamore Row",
                        Author = "John Grisham",
                        publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction, Thrillers",
                        Price = 15.03,
                        NumPages = 642,
                        WebLink = "https://www.amazon.com/Sycamore-Row-Novel-Jake-Brigance-ebook/dp/" +
                        "B00CNQ7HAU/ref=sr_1_1?dchild=1&keywords=sycamore+row&qid=1614218188&sr=8-1"
                    },
                    new Project
                    {
                        Title = "The Way of Kings", 
                        Author = "Brandon Sanderson",
                        publisher = "TOR", 
                        ISBN = "978-0792771999",
                        Classification = "Fiction, Fantasy",
                        Price = 39.99,
                        NumPages = 1007,
                        WebLink = "https://www.amazon.com/The-Way-of-Kings-audiobook/dp/" +
                        "B0041JKFJW/ref=sr_1_1?dchild=1&keywords=The+way+of+kings&qid=1614218211&sr=8-1"
                    },
                    new Project
                    {
                        Title = "Ender's Game",
                        Author = "Orison Scott Card",
                        publisher = "TOR", 
                        ISBN = "978-0812550702",
                        Classification = "Fiction, Sci-Fi",
                        Price = 7.99,
                        NumPages = 324,
                        WebLink = "https://www.amazon.com/Enders-Game-Special-20th-Anniversary/dp/" +
                        "B00006JMD2/ref=sr_1_1?dchild=1&keywords=enders+game&qid=1614218299&s=audible&sr=1-1"
                    },
                    new Project
                    { 
                        Title = "Rich Dad, Poor Dad", 
                        Author = "Robert Kiyosaki",
                        publisher = "Warner Books Ed",
                        ISBN = "978-1469202167",
                        Classification = "Non-Fiction, Financial",
                        Price = 4.99, 
                        NumPages = 207,
                        WebLink = "https://www.amazon.com/Rich-Dad-Poor-Dad-Robert-T-Kiyosaki-audio/dp/" +
                        "B008BUHTLE/ref=sr_1_1?dchild=1&keywords=rich+dad+poor+dad&qid=1614218326&s=audible&sr=1-1"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
