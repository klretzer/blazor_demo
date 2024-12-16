namespace BlazorDemo.Web.Data;

public static class SeedData
{
    public static async Task InitializeAsync(PizzaStoreContext context)
    {
        var specials = new PizzaSpecial[]
        {
            new()
            {
                Name = "Cheese Pizza",
                Description = "It's cheesy and delicious. Get one.",
                BasePrice = 9.99M,
                ImageUrl = "img/pizzas/cheese.jpg"
            },
            new()
            {
                Name = "The Baconatorizer",
                Description = "It has every kind of bacon.",
                BasePrice = 11.99M,
                ImageUrl = "img/pizzas/bacon.jpg"
            },
            new()
            {
                Name = "Classic Pepperoni",
                Description = "It's the pizza you grew up with.",
                BasePrice = 10.50M,
                ImageUrl = "img/pizzas/pepperoni.jpg"
            },
            new()
            {
                Name = "Buffalo Chicken",
                Description = "Spicy chicken, hot sauce and blue cheese.",
                BasePrice = 12.75M,
                ImageUrl = "img/pizzas/meaty.jpg"
            },
            new()
            {
                Name = "Mushroom Lovers",
                Description = "It has mushrooms.",
                BasePrice = 11.00M,
                ImageUrl = "img/pizzas/mushroom.jpg"
            },
            new()
            {
                Name = "Veggie Delight",
                Description = "It's like salad, but on a pizza.",
                BasePrice = 11.5M,
                ImageUrl = "img/pizzas/salad.jpg"
            },
            new()
            {
                Name = "Margherita",
                Description = "Traditional with tomatoes and basil.",
                BasePrice = 9.99M,
                ImageUrl = "img/pizzas/margherita.jpg"
            },
            new()
            {
                Id = 9,
                Name = "Margherita Family Size",
                Description = "24\" of pure tomatoes and basil.",
                BasePrice = 14.99M,
                ImageUrl = "img/pizzas/margherita.jpg",
                FixedSize = 24
            }
        };

        context.Specials.AddRange(specials);

        await context.SaveChangesAsync();
    }
}
