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
            // ✅ Explicitly assign DbPath
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DbPath = Path.Combine(path, "Sewing.db");

            Debug.WriteLine($"📂 ef Database Path: {DbPath}");
            Console.WriteLine($"📂 ef Database Path: {DbPath}");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // ✅ Now DbPath will always be assigned before use
                optionsBuilder.UseSqlite($"Filename={DbPath}");
            }
        }
    }
}
