using Berdsk.Sdk.PagarMe.V5;
using Microsoft.Extensions.Configuration;
using System;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration
{
    public class PagarMeFixture : IDisposable
    {
        public PagarMeClient Client { get; private set; }
        public IConfiguration Configuration { get; private set; }

        public PagarMeFixture()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var apiKey = Configuration["PagarMe:SecretKey"] ?? "sk_test_default"; // Fallback para compilação, mas deve ser fornecida
            var baseUrl = Configuration["PagarMe:BaseUrl"] ?? "https://api.pagar.me/core/v5/";

            Client = new PagarMeClient(apiKey, baseUrl);
        }

        public void Dispose()
        {
            // HttpClient é gerenciado internamente pelo PagarMeClient neste caso, 
            // ou pode ser injetado se quisermos mais controle.
        }
    }
}
