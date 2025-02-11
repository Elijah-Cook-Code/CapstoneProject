using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.IO;

namespace MudDb.Data
{
    public class MudDbFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var dbPath = Path.Combine(path, "Sewing.db");

            Console.WriteLine($"📂 Factory Database Path: {dbPath}");
            optionsBuilder.UseSqlite($"Filename={dbPath}");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
