using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class CustomerIntegrationTests : IClassFixture<PagarMeFixture>
{
    private readonly PagarMeClient _client;
    private readonly Faker _faker;

    public CustomerIntegrationTests(PagarMeFixture fixture)
    {
        _client = fixture.Client;
        _faker = new Faker("pt_BR");
    }

    [Fact]
    public async Task CreateCustomer_WithValidData_ShouldReturnCreatedCustomer()
    {
        // Arrange
        var request = new PmCreateCustomerRequest
        {
            Name = _faker.Person.FullName,
            Email = _faker.Internet.Email(),
            Document = _faker.Person.Cpf(false),
            Type = "individual",
            Code = $"TEST_{_faker.Random.Guid()}"
        };

        // Act
        var response = await _client.Customer.CreateCustomerAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().NotBeNullOrEmpty();
        response.Name.Should().Be(request.Name);
        response.Email.Should().Be(request.Email);
        response.Document.Should().Be(request.Document);
    }

    [Fact]
    public async Task GetCustomer_ShouldReturnCustomerDetails()
    {
        // Arrange
        var createRequest = new PmCreateCustomerRequest
        {
            Name = _faker.Person.FullName,
            Email = _faker.Internet.Email(),
            Document = _faker.Person.Cpf(false),
            Type = "individual"
        };
        var created = await _client.Customer.CreateCustomerAsync(createRequest);

        // Act
        var response = await _client.Customer.GetCustomerAsync(created.Id);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().Be(created.Id);
        response.Name.Should().Be(createRequest.Name);
    }

    [Fact]
    public async Task UpdateCustomer_ShouldModifyCustomerData()
    {
        // Arrange
        var createRequest = new PmCreateCustomerRequest
        {
            Name = _faker.Person.FullName,
            Email = _faker.Internet.Email(),
            Document = _faker.Person.Cpf(false),
            Type = "individual"
        };
        var created = await _client.Customer.CreateCustomerAsync(createRequest);

        var updateRequest = new PmUpdateCustomerRequest
        {
            Name = "Updated Name " + _faker.Random.AlphaNumeric(5),
            Email = "updated_" + _faker.Internet.Email()
        };

        // Act
        var response = await _client.Customer.UpdateCustomerAsync(created.Id, updateRequest);

        // Assert
        response.Should().NotBeNull();
        response.Name.Should().Be(updateRequest.Name);
        response.Email.Should().Be(updateRequest.Email);
    }

    [Fact]
    public async Task ListCustomers_ShouldReturnAtLeastOneCustomer()
    {
        // Arrange
        await CreateCustomer_WithValidData_ShouldReturnCreatedCustomer();

        // Act
        var response = await _client.Customer.ListCustomersAsync(size: 10);

        // Assert
        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();
        response.Data.Should().NotBeEmpty();
    }
}