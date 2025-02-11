using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudDb.Data;
using System;
using System.Linq.Expressions;

namespace MudDb.Services
{
    public static class ApplyMigrations
    {
        public static void Run(IServiceProvider serviceProvider)
        {
            try
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    // ✅ Log the database path to confirm it's the right one
                    Console.WriteLine($"📂 Applying migrations to database at: {context.DbPath}");
                    context.Database.Migrate(); // Apply any pending migrations
                    Console.WriteLine("✅ Database migration completed successfully.");

                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error applying migrations: {ex.Message}");
                Console.WriteLine($"❌ StackTrace: {ex.StackTrace}");
            }
        }
       

    }
}
