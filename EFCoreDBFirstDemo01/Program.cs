using EFCoreDBFirstDemo01.Models;
using Microsoft.EntityFrameworkCore;

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


public class Program
{
    private static void Main(string[] args)
    {
        using (var myContext = new ApplicationContext())
        {
            foreach (var order in myContext.Orders.OrderBy(o => o.OrderID))
            {
                Console.WriteLine($"{order.OrderID}: {order.CustomerName}");
            }
        }
    }
}



