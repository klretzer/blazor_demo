var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddHttpClient()
    .AddSqlite<PizzaStoreContext>("Data Source=Data/pizza.db")
    .AddScoped<OrderState>()
    .AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();

    if (db.Database.EnsureCreated())
    {
        await SeedData.InitializeAsync(db);
    }
}

app.Run();