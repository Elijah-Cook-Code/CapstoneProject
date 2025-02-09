using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MudDb.Data;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Sewing.db");

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite($"Filename={dbPath}")
        );

        using (var serviceProvider = services.BuildServiceProvider())
        {
            using (var context = serviceProvider.GetRequiredService<AppDbContext>())
            {
                var pendingMigrations = context.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    Console.WriteLine("Applying migrations...");
                    context.Database.Migrate();
                    Console.WriteLine("Migrations applied successfully.");
                }
                else
                {
                    Console.WriteLine("✅ No pending migrations.");
                }
            }

        }
    }
}
