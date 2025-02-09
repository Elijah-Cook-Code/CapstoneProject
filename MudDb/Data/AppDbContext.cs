using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.IO;

namespace MudDb.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public string DbPath { get; private set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // ✅ Fix: Use a cross-platform database path
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DbPath = Path.Combine(appDataPath, "Sewing.db");

            // ✅ Log Database Path for Debugging
            Debug.WriteLine($"📂 Database Path: {DbPath}");
            Console.WriteLine($"📂 Database Path: {DbPath}");
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Sewing.db");
                optionsBuilder.UseSqlite($"Filename={dbPath}");  // ✅ Use Correct Path
            }
        }
    }
}
