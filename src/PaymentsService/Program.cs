var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { service = "PaymentsService", project = "Lavandería Olivo" });
app.MapGet("/health", () => Results.Ok(new { status = "healthy", service = "payments" }));

app.Run();

public partial class Program { }
