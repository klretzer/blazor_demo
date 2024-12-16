namespace BlazorDemo.Web.Data;

public class PizzaStoreContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Order> Orders { get; set; }

    public DbSet<Pizza> Pizzas { get; set; }

    public DbSet<PizzaSpecial> Specials { get; set; }

    public DbSet<Topping> Toppings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PizzaTopping>().HasKey(pt => new { pt.PizzaId, pt.ToppingId });
        modelBuilder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(p => p.Toppings);
        modelBuilder.Entity<PizzaTopping>().HasOne(pt => pt.Topping).WithMany();
    }
}
