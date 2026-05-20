using Berdsk.Sdk.PagarMe.V5.Exceptions;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using FluentAssertions;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class ErrorHandlingIntegrationTests : IClassFixture<PagarMeFixture>
{
    private readonly PagarMeClient _client;

    public ErrorHandlingIntegrationTests(PagarMeFixture fixture)
    {
        _client = fixture.Client;
    }

    [Fact]
    public async Task CreateCustomer_WithInvalidData_ShouldThrowPmValidationException()
    {
        // Arrange
        var request = new PmCreateCustomerRequest
        {
            Name = "", // Nome vazio para forçar erro
            Email = "invalid-email",
            Type = "individual"
        };

        // Act
        var act = async () => await _client.Customer.CreateCustomerAsync(request);

        // Assert
        await act.Should().ThrowAsync<PmValidationException>()
            .Where(e => e.ErrorResponse != null && e.ErrorResponse.Errors != null);
    }
}