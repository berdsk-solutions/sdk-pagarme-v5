using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;
using Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos;
using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;

namespace Berdsk.Sdk.PagarMe.V5.Tests.Integration;

public class OrderIntegrationTests : IClassFixture<PagarMeFixture>
{
    private readonly PagarMeClient _client;
    private readonly Faker _faker;

    public OrderIntegrationTests(PagarMeFixture fixture)
    {
        _client = fixture.Client;
        _faker = new Faker("pt_BR");
    }

    [Fact]
    public async Task CreateOrder_WithBoleto_ShouldReturnCreatedOrder()
    {
        // Arrange
        var request = new PmCreateOrderRequest
        {
            Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
            Customer = CreateBasicCustomerRequest(),
            Items = CreateBasicItems(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "boleto",
                    Boleto = new PmOrderBoletoRequest
                    {
                        Bank = "033", // Santander para teste
                        Instructions = "Pagar até o vencimento"
                    }
                }
            }
        };

        // Act
        var response = await _client.Order.CreateOrderAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Id.Should().NotBeNullOrEmpty();
        response.Status.Should().Be("pending");
        response.Charges.Should().NotBeEmpty();
        response.Charges[0].PaymentMethod.Should().Be("boleto");
    }

    [Fact]
    public async Task CreateOrder_WithBoleto_Advanced_ShouldWork()
    {
        // Arrange
        var request = new PmCreateOrderRequest
        {
            Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
            Customer = CreateBasicCustomerRequest(),
            Items = CreateBasicItems(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "boleto",
                    Boleto = new PmOrderBoletoRequest
                    {
                        Instructions = "Pagar até o vencimento",
                        DueAt = DateTime.Now.AddDays(3).ToString("yyyy-MM-ddTHH:mm:ssZ"),
                        DocumentNumber = "123456",
                        Type = "DM",
                        Interest = new PmBoletoInterestRequest
                        {
                            Days = 1,
                            Type = "percentage",
                            Amount = 1.0m
                        },
                        Fine = new PmBoletoFineRequest
                        {
                            Days = 1,
                            Type = "flat",
                            Amount = 100
                        },
                        Metadata = new Dictionary<string, string>
                        {
                            { "test_key", "test_value" }
                        }
                    }
                }
            }
        };

        // Act
        var response = await _client.Order.CreateOrderAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Status.Should().Be("pending");
        response.Charges.Should().NotBeEmpty();
        var lastTransaction = response.Charges[0].LastTransaction;
        lastTransaction.TransactionType.Should().Be("boleto");
        lastTransaction.Success.Should().BeTrue();
    }

    [Fact]
    public async Task CreateOrder_WithCreditCard_Success_ShouldBePaid()
    {
        // Arrange - Usando cartão de sucesso do simulador
        var request = new PmCreateOrderRequest
        {
            Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
            Customer = CreateBasicCustomerRequest(),
            Items = CreateBasicItems(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "credit_card",
                    CreditCard = new PmOrderCreditCardRequest
                    {
                        Card = new PmOrderCardRequest
                        {
                            Number = "4000000000000010", // Cartão de Sucesso
                            HolderName = "CAPT MARVEL",
                            ExpMonth = 12,
                            ExpYear = 2030,
                            Cvv = "123",
                            BillingAddress = new PmCreateCustomerAddressRequest
                            {
                                Line1 = "123, Rua Teste, Bairro Teste",
                                ZipCode = "01234567",
                                City = "São Paulo",
                                State = "SP",
                                Country = "BR"
                            }
                        },
                        Installments = 1,
                        StatementDescriptor = "LOJA TESTE"
                    }
                }
            }
        };

        // Act
        var response = await _client.Order.CreateOrderAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Status.Should().Be("paid");
        response.Charges[0].Status.Should().Be("paid");
        response.Charges[0].LastTransaction.Success.Should().BeTrue();
    }

    // [Fact]
    // public async Task CreateOrder_WithCreditCardAndBillingAddress_ShouldWork()
    // {
    //     // Arrange
    //     var request = new PmCreateOrderRequest
    //     {
    //         Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
    //         Customer = CreateBasicCustomerRequest(),
    //         Items = CreateBasicItems(),
    //         Payments = new List<PmOrderPaymentRequest>
    //         {
    //             new PmOrderPaymentRequest
    //             {
    //                 PaymentMethod = "credit_card",
    //                 CreditCard = new PmOrderCreditCardRequest
    //                 {
    //                     Card = new PmOrderCardRequest
    //                     {
    //                         Number = "4000000000000010",
    //                         HolderName = "CAPT MARVEL",
    //                         ExpMonth = 12,
    //                         ExpYear = 2030,
    //                         Cvv = "123"
    //                     },
    //                     Installments = 1,
    //                     BillingAddress = new PmCreateCustomerAddressRequest
    //                     {
    //                         Line1 = "123, Rua Teste, Bairro Teste",
    //                         ZipCode = "01234567",
    //                         City = "São Paulo",
    //                         State = "SP",
    //                         Country = "BR"
    //                     }
    //                 }
    //             }
    //         }
    //     };
    //
    //     // Act
    //     var response = await _client.Order.CreateOrderAsync(request);
    //
    //     // Assert
    //     response.Should().NotBeNull();
    //     response.Status.Should().Be("paid");
    // }

    [Fact]
    public async Task CreateOrder_WithCreditCard_InsufficientFunds_ShouldBeFailed()
    {
        // Arrange - Usando cartão de saldo insuficiente (51)
        var request = new PmCreateOrderRequest
        {
            Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
            Customer = CreateBasicCustomerRequest(),
            Items = CreateBasicItems(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "credit_card",
                    CreditCard = new PmOrderCreditCardRequest
                    {
                        Card = new PmOrderCardRequest
                        {
                            Number = "4000000000000051", // Saldo Insuficiente
                            HolderName = "POOR GUY",
                            ExpMonth = 12,
                            ExpYear = 2030,
                            Cvv = "123"
                        },
                        Installments = 1
                    }
                }
            }
        };

        // Act
        var response = await _client.Order.CreateOrderAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Status.Should().Be("pending");
        response.Charges[0].Status.Should().Be("processing");
        response.Charges[0].LastTransaction.Success.Should().BeFalse();
    }

    [Fact]
    public async Task CreateOrder_WithDebitCard_Success_ShouldBePaid()
    {
        // Arrange - Usando cartão de débito de sucesso do simulador
        var request = new PmCreateOrderRequest
        {
            Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
            Customer = CreateBasicCustomerRequest(),
            Items = CreateBasicItems(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "debit_card",
                    DebitCard = new PmOrderDebitCardRequest
                    {
                        BillingAddress = new PmCreateCustomerAddressRequest
                        {
                            Line1 = "123, Rua Teste, Bairro Teste",
                            ZipCode = "01234567",
                            City = "São Paulo",
                            State = "SP",
                            Country = "BR"
                        },
                        Card = new PmOrderCardRequest
                        {
                            Number = "4000000000000010", // Débito Sucesso
                            HolderName = "DEBIT MASTER",
                            ExpMonth = 12,
                            ExpYear = 2030,
                            Cvv = "123"
                        }
                    }
                }
            }
        };

        // Act
        var response = await _client.Order.CreateOrderAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Status.Should().Be("paid");
        response.Charges[0].PaymentMethod.Should().Be("debit_card");
    }

    [Fact]
    public async Task CreateOrder_WithPix_ShouldReturnQrCode()
    {
        // Arrange
        var request = new PmCreateOrderRequest
        {
            Code = $"ORD_{_faker.Random.AlphaNumeric(10)}",
            Customer = CreateBasicCustomerRequest(),
            Items = CreateBasicItems(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "pix",
                    Pix = new PmOrderPixRequest
                    {
                        ExpiresIn = 3600,
                        AdditionalInformation = new List<PmOrderPixAdditionalInformationRequest>
                        {
                            new() { Name = "Quantidade", Value = "1" }
                        }
                    }
                }
            }
        };

        // Act
        var response = await _client.Order.CreateOrderAsync(request);

        // Assert
        response.Should().NotBeNull();
        response.Status.Should().Be("pending");
        response.Charges[0].PaymentMethod.Should().Be("pix");
        response.Charges[0].LastTransaction.Should().NotBeNull();
        response.Charges[0].LastTransaction.QrCode.Should().NotBeNullOrEmpty();
        response.Charges[0].LastTransaction.QrCodeUrl.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task GetOrder_ShouldReturnOrderDetails()
    {
        // Arrange
        var createRequest = new PmCreateOrderRequest
        {
            Items = CreateBasicItems(),
            Customer = CreateBasicCustomerRequest(),
            Payments = new List<PmOrderPaymentRequest>
            {
                new()
                {
                    PaymentMethod = "pix",
                    Pix = new PmOrderPixRequest
                    {
                        ExpiresIn = 3600
                    }
                }
            }
        };
        var created = await _client.Order.CreateOrderAsync(createRequest);
        created.Should().NotBeNull();

        // Act
        var response = await _client.Order.GetOrderAsync(created!.Id!);

        // Assert
        response.Should().NotBeNull();
        response!.Id.Should().Be(created.Id);
    }

    private PmCreateCustomerRequest CreateBasicCustomerRequest()
    {
        return new PmCreateCustomerRequest
        {
            Name = _faker.Person.FullName,
            Email = _faker.Internet.Email(),
            Document = _faker.Person.Cpf(false),
            Phones = new PmCreateCustomerPhonesRequest
            {
                MobilePhone = new PmCreateCustomerPhoneRequest
                {
                    CountryCode = "55",
                    AreaCode = "11",
                    Number = "999999999"
                }
            },
            Address = new PmCreateCustomerAddressRequest
            {
                Country = "BR",
                State = "SP",
                City = "São Paulo",
                ZipCode = "04187150",
                Line1 = "150, Rua Antônio Ferreira Bessa, Vila Liviero",
                Line2 = null
            },
            Type = "individual"
        };
    }

    private List<PmOrderItemRequest> CreateBasicItems()
    {
        return new List<PmOrderItemRequest>
        {
            new()
            {
                Amount = 1000,
                Description = "Test Item",
                Quantity = 1,
                Code = "ITEM_1"
            }
        };
    }
}