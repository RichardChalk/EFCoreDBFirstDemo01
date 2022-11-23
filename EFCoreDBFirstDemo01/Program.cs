using EFCoreDBFirstDemo01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// https://entityframeworkcore.com/approach-code-first

// Step 1
// Installera Microsoft.EntityFrameworkCore.SqlServer
// Installera Microsoft.EntityFrameworkCore.Tools

// Step 2
// Skapa alla klasser som behövs för din databas

// Step 3
// Skapa din DbContext med relevanta Dbsets

// Step 4
// Installera ett sista nuget paket - Microsoft.EntityFrameworkCore.Design

// Step 5
// Nu kan vi köra denna command i nuget consolen
// Add-Migration RichardsInitialMigration

// Step 6
// Nu kan vi köra denna command i nuget consolen
// Update-Database

// Step 7
// Nu kan vi loop igenom våra order o Orders tabellen

// Step 8
// Installera Microsoft.Extensions.Configuration nuget paket
// Installera Microsoft.Extensions.Configuration.json nuget paket

// Step 9
// (Svårare) Lägg till appsettings.json (glöm inte Property "Copy if newer!!")

// Step 10
// Loopar igenom något i din klass och visa den i console fönstret

public class Program
{
    private static void Main(string[] args)
    {
        var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.json", true, true);
        var config = builder.Build();

        // Hämta connection string från appsettings.json
        var connectionString = config.GetConnectionString("DefaultConnection");

        var options = new DbContextOptionsBuilder<ApplicationContext>();
        options.UseSqlServer(connectionString);

        using (var myContext = new ApplicationContext(options.Options))
        {
            foreach (var order in myContext.Orders.OrderBy(o => o.OrderID))
            {
                Console.WriteLine($"{order.OrderID}: {order.CustomerName}");
            }
        }
    }
}



