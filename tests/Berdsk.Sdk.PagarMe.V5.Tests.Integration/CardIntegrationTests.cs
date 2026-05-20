using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class CardIntegrationTests : IClassFixture<PagarMeFixture>
{
    private readonly PagarMeClient _client;
    private readonly Faker _faker;

    public CardIntegrationTests(PagarMeFixture fixture)
    {
        _client = fixture.Client;
        _faker = new Faker("pt_BR");
    }

    private async Task<string> CreateTestCustomerAsync()
    {
        var request = new PmCreateCustomerRequest
        {
            Name = _faker.Person.FullName,
            Email = _faker.Internet.Email(),
            Document = _faker.Person.Cpf(false),
            Type = "individual"
        };
        var customer = await _client.Customer.CreateCustomerAsync(request);
        return customer.Id;
    }

    [Fact]
    public async Task CreateCard_ShouldReturnCreatedCard()
    {
        // Arrange
        var customerId = await CreateTestCustomerAsync();
        var request = new PmCreateCardRequest
        {
            Number = "4000000000000010", // Visa Test
            HolderName = "Junie Test",
            ExpMonth = 12,
            ExpYear = DateTime.Now.Year + 2,
            Cvv = "123",
            Brand = "visa",
            Options = new PmCreateCardOptionsRequest { VerifyCard = true }
        };

        // Act
        var response = await _client.Customer.Cards.CreateCardAsync(customerId, request);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().NotBeNullOrEmpty();
        response.LastFourDigits.Should().Be("0010");
    }

    [Fact]
    public async Task ListCards_ShouldReturnCardsForCustomer()
    {
        // Arrange
        var customerId = await CreateTestCustomerAsync();

        // Criar um cartão para garantir que a lista não esteja vazia
        var cardRequest = new PmCreateCardRequest
        {
            Number = "4000000000000010",
            HolderName = "Junie Test",
            ExpMonth = 12,
            ExpYear = DateTime.Now.Year + 2,
            Cvv = "123"
        };
        await _client.Customer.Cards.CreateCardAsync(customerId, cardRequest);

        await Task.Delay(3000);

        // Act
        var response = await _client.Customer.Cards.ListCardsAsync(customerId);

        // Assert
        response.Should().NotBeNull();
        response.Data.Should().NotBeEmpty();
    }

    [Fact]
    public async Task CreateCard_WithDifferentBrands_ShouldWork()
    {
        // Arrange
        var customerId = await CreateTestCustomerAsync();
        var cards = new[]
        {
            new { Number = "4000000000000010", Brand = "visa" }
        };

        foreach (var card in cards)
        {
            var request = new PmCreateCardRequest
            {
                Number = card.Number,
                HolderName = "SIMULATOR TEST",
                ExpMonth = 12,
                ExpYear = DateTime.Now.Year + 5,
                Cvv = "123"
            };

            // Act
            var response = await _client.Customer.Cards.CreateCardAsync(customerId, request);

            // Assert
            response.Should().NotBeNull();
            response.Brand.ToLower().Should().Be(card.Brand);
        }
    }
}