using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MudDb.Data
{
    // ✅ This class tells EF Core how to create the AppDbContext at design-time
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        // 🔹 This method is called when EF needs to create a DbContext for migrations
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // ✅ Define the database path
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(path, "Sewing.db");

            // ✅ Configure EF Core to use SQLite with the database path
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            // ✅ Return a new AppDbContext with the configured options
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
