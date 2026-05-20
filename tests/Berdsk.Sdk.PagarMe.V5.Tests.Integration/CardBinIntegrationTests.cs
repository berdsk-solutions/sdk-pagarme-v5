using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration
{
    public class CardBinIntegrationTests : IClassFixture<PagarMeFixture>
    {
        private readonly PagarMeClient _client;

        public CardBinIntegrationTests(PagarMeFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task GetBin_WithValidBin_ShouldReturnBinDetails()
        {
            // Arrange
            var validBin = "411111"; // Exemplo de BIN Visa de teste

            // Act
            var response = await _client.CardBin.GetBinAsync(validBin);

            // Assert
            response.Should().NotBeNull();
            response.Brand.Should().NotBeNullOrEmpty();
        }
    }
}
