using Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration
{
    public class AddressIntegrationTests : IClassFixture<PagarMeFixture>
    {
        private readonly PagarMeClient _client;
        private readonly Faker _faker;

        public AddressIntegrationTests(PagarMeFixture fixture)
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
        public async Task CreateAddress_ShouldReturnCreatedAddress()
        {
            // Arrange
            var customerId = await CreateTestCustomerAsync();
            var request = new PmCreateAddressRequest
            {
                Line1 = $"{_faker.Address.BuildingNumber()}, {_faker.Address.StreetName()}, {_faker.Address.SecondaryAddress()}",
                ZipCode = _faker.Address.ZipCode().Replace("-", ""),
                City = _faker.Address.City(),
                State = "SP",
                Country = "BR"
            };

            // Act
            var response = await _client.Customer.Addresses.CreateAddressAsync(customerId, request);

            // Assert
            response.Should().NotBeNull();
            response.Id.Should().NotBeNullOrEmpty();
            response.City.Should().Be(request.City);
        }

        [Fact]
        public async Task ListAddresses_ShouldReturnAddressesForCustomer()
        {
            // Arrange
            var customerId = await CreateTestCustomerAsync();
            await CreateAddress_ShouldReturnCreatedAddress(); // No contexto de outra execução, mas vamos criar um aqui
            
            var request = new PmCreateAddressRequest
            {
                Line1 = "123, Rua Teste, Bairro",
                ZipCode = "01234000",
                City = "São Paulo",
                State = "SP",
                Country = "BR"
            };
            await _client.Customer.Addresses.CreateAddressAsync(customerId, request);
            await Task.Delay(3000);
            // Act
            var response = await _client.Customer.Addresses.ListAddressesAsync(customerId);

            // Assert
            response.Should().NotBeNull();
            response.Data.Should().NotBeEmpty();
        }
    }
}
