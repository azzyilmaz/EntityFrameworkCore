// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");


public class EticaretContext : DbContext 
{ 
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=AZZYLMZ\\SQLEXPRESS;Database=ETicaretDB;Trusted_Connection=True;");
    }
}

public class Product
{
    public int Id { get; set; }
}