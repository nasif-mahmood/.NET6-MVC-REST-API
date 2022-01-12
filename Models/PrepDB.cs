using Commander.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Commander.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CommanderContext>());
            }
        }

        public static void SeedData(CommanderContext context)
        {
            System.Console.WriteLine("Applying Migrations... ");

            context.Database.Migrate();

            if(!context.Commands.Any())
            {
                System.Console.WriteLine("Adding data - seeding...");
                context.Commands.AddRange(
                    new Command() {HowTo="How to create migrations", Line="dotnet ef migrations add <Name of Migration>", Platform="EF Core"},
                    new Command() {HowTo="How to run migrations", Line="dotnet ef database update", Platform="EF Core"},
                    new Command() {HowTo="How to run a .NET app", Line="dotnet run", Platform=".NET CLI"}
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data - not seeding");
            }
        }

    }
}