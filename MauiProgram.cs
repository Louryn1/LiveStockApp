// MauiProgram.cs: Dependency setup for database and other services
using Microsoft.Maui.Hosting;
using Microsoft.Extensions.DependencyInjection;
using LiveStockApp.Database;
using System.IO;

namespace LiveStockApp
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

            // Set up SQLite database with provided path
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FarmDataOriginal.db");
            builder.Services.AddSingleton(s => new DatabaseService(dbPath));

            return builder.Build();
        }
    }
}
