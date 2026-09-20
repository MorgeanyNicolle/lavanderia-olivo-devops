namespace LavanderiaOlivo.Tests;

public class BasicTests
{
    [Fact]
    public void ServiceNames_ShouldContainFourEntries()
    {
        var services = new[] { "auth", "catalog", "orders", "payments" };
        Assert.Equal(4, services.Length);
    }

    [Fact]
    public void LaundryOrderStates_ShouldIncludeDelivered()
    {
        var states = new[] { "Recibida", "Lavado", "Secado", "Planchado", "Lista para entrega", "Entregada" };
        Assert.Contains("Entregada", states);
    }
}
