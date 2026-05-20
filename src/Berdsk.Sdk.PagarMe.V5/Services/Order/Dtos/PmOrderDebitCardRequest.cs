using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados sobre o pagamento com cartão de débito
    /// </summary>
    public class PmOrderDebitCardRequest
    {
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        [JsonPropertyName("card")] public PmOrderCardRequest? Card { get; set; }

        [JsonPropertyName("card_id")] public string? CardId { get; set; }

        [JsonPropertyName("card_token")] public string? CardToken { get; set; }

        [JsonPropertyName("billing_address_id")]
        public string? BillingAddressId { get; set; }

        [JsonPropertyName("billing_address")] public PmCreateCustomerAddressRequest? BillingAddress { get; set; }
    }
}