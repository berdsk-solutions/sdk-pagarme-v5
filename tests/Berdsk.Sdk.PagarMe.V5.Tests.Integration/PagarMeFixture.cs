using Microsoft.Extensions.Configuration;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class PagarMeFixture : IDisposable
{
    public PagarMeFixture()
    {
        Configuration = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();

        var apiKey = Configuration["PAGARME_SECRET_KEY"] ?? Configuration["PagarMe:SecretKey"];
        var baseUrl = Configuration["PAGARME_BASE_URL"] ?? Configuration["PagarMe:BaseUrl"] ?? "https://api.pagar.me/core/v5/";
        
        if (string.IsNullOrEmpty(apiKey))
            throw new InvalidOperationException("PagarMe API Key não fornecida. Defina a variável de ambiente PAGARME_SECRET_KEY.");
        
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