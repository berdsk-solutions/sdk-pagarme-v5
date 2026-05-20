using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Cartão para pagamento
    /// </summary>
    public class PmOrderCardRequest
    {
        [JsonPropertyName("number")] public string? Number { get; set; }

        [JsonPropertyName("holder_name")] public string? HolderName { get; set; }

        [JsonPropertyName("holder_document")] public string? HolderDocument { get; set; }

        [JsonPropertyName("exp_month")] public int ExpMonth { get; set; }

        [JsonPropertyName("exp_year")] public int ExpYear { get; set; }

        [JsonPropertyName("cvv")] public string? Cvv { get; set; }

        [JsonPropertyName("billing_address")] public PmCreateCustomerAddressRequest? BillingAddress { get; set; }

        [JsonPropertyName("billing_address_id")]
        public string? BillingAddressId { get; set; }
    }
}


