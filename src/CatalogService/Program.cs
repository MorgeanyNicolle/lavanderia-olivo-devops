var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var services = new[] { "Lavado", "Secado", "Planchado" };
app.MapGet("/", () => new { service = "CatalogService", project = "Lavandería Olivo" });
app.MapGet("/health", () => Results.Ok(new { status = "healthy", service = "catalog" }));
app.MapGet("/services", () => Results.Ok(services));

app.Run();

public partial class Program { }
