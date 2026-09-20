var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { service = "AuthService", project = "Lavandería Olivo" });
app.MapGet("/health", () => Results.Ok(new { status = "healthy", service = "auth" }));

app.Run();

public partial class Program { }
