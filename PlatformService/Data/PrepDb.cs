using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Platforms.AddRange(
                    new Models.Platform() { Name="Dot Net", Publisher="Microsoft", Cost="Free"},
                    new Models.Platform() { Name="Java", Publisher="Oracle", Cost="Free"},
                    new Models.Platform() { Name="C#", Publisher="Microsoft", Cost="Free"},
                    new Models.Platform() { Name="Python", Publisher="Google", Cost="Free"},
                    new Models.Platform() { Name="Ruby", Publisher="Oracle", Cost="Free"},
                    new Models.Platform() { Name="JavaScript", Publisher="Microsoft", Cost="Free"},
                    new Models.Platform() { Name="C++", Publisher="Microsoft", Cost="Free"},
                    new Models.Platform() { Name="Swift", Publisher="Apple", Cost="Free"},
                    new Models.Platform() { Name="Kotlin", Publisher="JetBrains", Cost="Free"},
                    new Models.Platform() { Name="Go", Publisher="Google", Cost="Free"},
                    new Models.Platform() { Name="PHP", Publisher="Drupal", Cost="Free"},
                    new Models.Platform() { Name="Perl", Publisher="Perl", Cost="Free"},
                    new Models.Platform() { Name="Scala", Publisher="Oracle", Cost="Free"},
                    new Models.Platform() { Name="Objective-C", Publisher="Apple", Cost="Free"}
                );

                context.SaveChanges();
            }
            else 
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}