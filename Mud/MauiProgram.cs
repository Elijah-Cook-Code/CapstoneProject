using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MudDb.Data;
using MudBlazor.Services;
using System.Diagnostics;
using MudDb.Services;



namespace Mud
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddMudServices();

            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "Sewing.db");

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlite($"Filename={dbPath}")
            );

            builder.Services.AddScoped<DatabaseService>();

            // ✅ Ensure Migrations Are Applied Once
            using (var scope = builder.Services.BuildServiceProvider().CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                var dbService = scope.ServiceProvider.GetRequiredService<DatabaseService>();
                try
                {
                    
                    db.Database.Migrate(); // ✅ Apply Migrations Here
                    Console.WriteLine("✅ Migrations Applied Successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ Migration Error: {ex.Message}");
                }
            }

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
