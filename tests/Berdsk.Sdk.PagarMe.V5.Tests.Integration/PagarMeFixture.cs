using Microsoft.Extensions.Configuration;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class PagarMeFixture : IDisposable
{
    public PagarMeFixture()
    {
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.test.json", true)
            .AddEnvironmentVariables()
            .Build();

        var apiKey =
            Configuration["PagarMe:SecretKey"] ?? "sk_test_default"; // Fallback para compilação, mas deve ser fornecida
        var baseUrl = Configuration["PagarMe:BaseUrl"] ?? "https://api.pagar.me/core/v5/";

        Console.WriteLine($"PagarMe API Key [FOR DEBUG]: {apiKey[^5]}");
        
        Client = new PagarMeClient(apiKey, baseUrl);
    }

    public PagarMeClient Client { get; private set; }
    public IConfiguration Configuration { get; }

    public void Dispose()
    {
        // HttpClient é gerenciado internamente pelo PagarMeClient neste caso, 
        // ou pode ser injetado se quisermos mais controle.
    }
}