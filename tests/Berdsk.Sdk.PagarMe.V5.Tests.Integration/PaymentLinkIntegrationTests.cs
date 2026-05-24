using Berdsk.Sdk.PagarMe.V5.Helpers;
using Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Bogus;
using FluentAssertions;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class PaymentLinkIntegrationTests : IClassFixture<PagarMeFixture>
{
    private readonly PagarMeClient _client;
    private readonly Faker _faker;

    public PaymentLinkIntegrationTests(PagarMeFixture fixture)
    {
        _client = fixture.Client;
        _faker = new Faker("pt_BR");
    }

    [Fact]
    public async Task CreatePaymentLink_WithValidData_ShouldReturnCreatedLink()
    {
        // Arrange
        var customer = await CreateTestCustomer();
        var request = GetValidRequest(customer.Id);

        // Act
        var response = await _client.PaymentLink.CreatePaymentLinkAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().NotBeNullOrEmpty();
        response.Name.Should().Be(request.Name);
        response.Url.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task CreatePaymentLink_WithBoleto_ShouldReturnCreatedLink()
    {
        // Arrange
        var customer = await CreateTestCustomer();
        var request = GetValidRequest(customer.Id);
        request.PaymentSettings.AcceptedPaymentMethods = new List<string> { PmPaymentMethod.Boleto };
        request.PaymentSettings.BoletoSettings = new PmPaymentLinkBoletoSettingsRequest
        {
            Instructions = "Pagar até o vencimento",
            DueIn = 5,
            Discount = 100 // 1 real de desconto
        };

        // Act
        var response = await _client.PaymentLink.CreatePaymentLinkAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().NotBeNullOrEmpty();
        response.PaymentSettings.AcceptedPaymentMethods.Should().Contain(PmPaymentMethod.Boleto);
    }

    [Fact]
    public async Task GetPaymentLink_ShouldReturnLinkDetails()
    {
        // Arrange
        var customer = await CreateTestCustomer();
        var createRequest = GetValidRequest(customer.Id);
        var created = await _client.PaymentLink.CreatePaymentLinkAsync(createRequest);

        // Act
        var response = await _client.PaymentLink.GetPaymentLinkAsync(created!.Id);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().Be(created.Id);
        response.Name.Should().Be(createRequest.Name);
    }

    private async Task<PmCustomerResponse> CreateTestCustomer()
    {
        var request = new PmCreateCustomerRequest
        {
            Name = _faker.Person.FullName,
            Email = _faker.Internet.Email(),
            Type = "individual",
            Document = "00000000000"
        };
        return await _client.Customer.CreateCustomerAsync(request);
    }

    private PmCreatePaymentLinkRequest GetValidRequest(string customerId)
    {
        return new PmCreatePaymentLinkRequest
        {
            Name = $"Compra de {_faker.Person.FullName}",
            OrderCode = "LINK-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
            Type = "order",
            CustomerSettings = new PmPaymentLinkCustomerSettingsRequest
            {
                CustomerId = customerId
            },
            PaymentSettings = new PmPaymentLinkPaymentSettingsRequest
            {
                AcceptedPaymentMethods = new List<string> 
                { 
                    PmPaymentMethod.CreditCard, 
                    PmPaymentMethod.Pix
                },
                PixSettings = new PmPaymentLinkPixSettingsRequest
                {
                    ExpiresIn = 3600
                },
                CreditCardSettings = new PmPaymentLinkCreditCardSettingsRequest
                {
                    OperationType = "auth_and_capture",
                    InstallmentsSetup = new PmPaymentLinkInstallmentsSetupRequest
                    {
                        MaxInstallments = 12,
                        Amount = 1000,
                        InterestType = "simple",
                        InterestRate = 5,
                        FreeInstallments = 2
                    }
                }
            },
            ExpiresIn = 120,
            CartSettings = new PmPaymentLinkCartSettingsRequest
            {
                Items = new List<PmPaymentLinkItemRequest>
                {
                    new()
                    {
                        Amount = 1000,
                        Name = "Produto de Teste",
                        DefaultQuantity = 1,
                        Description = "Produto de Teste"
                    }
                }
            }
        };
    }
}
