// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

#region Sorulması Gereken Sorular
/*
 1-SaveChanges Nedir?Nasıl verimli kullanılır?
 2-ChangeTracker Nedir?
 3-Bir verinin eklenme durumunu nasıl gözlemlemlerim?(Entry.state fonksiyonu)
 4-Async methodlar niçin kullanılır?
 */
#endregion


ETicaretContext context = new();
Product product = new()
{
    Name= "B Ürünü",
    Price=2000
};
Product product1 = new()
{
    Name = "C Ürünü",
    Price = 3000
};
Product product2 = new()
{
    Name = "D Ürünü",
    Price = 4000
};
await context.AddRangeAsync(product,product1,product2);
await context.SaveChangesAsync();

public class ETicaretContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=AZZYLMZ\\SQLEXPRESS;Database=ETicaretDB;Trusted_Connection=True;TrustServerCertificate=True");
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
}