var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { service = "OrdersService", project = "Lavandería Olivo" });
app.MapGet("/health", () => Results.Ok(new { status = "healthy", service = "orders" }));
app.MapGet("/states", () => Results.Ok(new[] { "Recibida", "Lavado", "Secado", "Planchado", "Lista para entrega", "Entregada" }));

app.Run();

public partial class Program { }
