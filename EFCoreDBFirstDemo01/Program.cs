// Step 1
// Installera Microsoft.EntityFrameworkCore.SqlServer
// Installera Microsoft.EntityFrameworkCore.Tools

// Step 2
// Skapa alla klasser som behövs för din databas

// Step 3
// Skapa din DbContext med relevanta Dbsets

// Step 4
// Installera ett sista nuget paket - Microsoft.EntityFrameworkCore.Design

using EFCoreDBFirstDemo01.Models;
using Microsoft.EntityFrameworkCore;

using (var myContext = new ApplicationContext())
{
    foreach (var order in myContext.Orders.OrderBy(o => o.OrderID))
    {
        Console.WriteLine($"{order.OrderID}: {order.OrderDetails}");
    }
}

