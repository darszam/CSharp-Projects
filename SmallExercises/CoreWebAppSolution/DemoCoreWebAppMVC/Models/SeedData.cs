using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreWebAppMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MusicContext(
                serviceProvider.GetRequiredService<DbContextOptions<MusicContext>>()))
            {
                // Look for any movies.
                if (context.Music.Any())
                {
                    return;   // DB has been seeded
                }

                context.Music.AddRange(
                     new Music
                     {
                         Title = "Fine Again",
                         ReleaseTime = DateTime.Parse("1989-1-11"),
                         Genre = "Rock",
                         Price = 7.99M,
                         Rating = "5"
                     },

                     new Music
                     {
                         Title = "Will Power",
                         ReleaseTime = DateTime.Parse("1984-3-13"),
                         Genre = "Rock",
                         Price = 8.99M,
                         Rating = "6"
                     },

                     new Music
                     {
                         Title = "Iridium",
                         ReleaseTime = DateTime.Parse("1986-2-23"),
                         Genre = "Rock",
                         Price = 9.99M,
                         Rating = "10"
                     },

                   new Music
                   {
                       Title = "Paper Moon",
                       ReleaseTime = DateTime.Parse("1959-4-15"),
                       Genre = "Rock",
                       Price = 3.99M,
                       Rating = "12"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
