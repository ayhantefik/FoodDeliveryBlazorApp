using FoodDelivery.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodDelivery.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }
    public DbSet<MenuProduct> products { get; set; }
    public DbSet<DonePurchase> donePurchases { get; set; }
    public DbSet<Eatery> eateries { get; set; }
}
