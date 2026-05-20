using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados para entrega
    /// </summary>
    public class PmOrderShippingRequest
    {
        /// <summary>
        ///     Valor da entrega. Em centavos.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        ///     Descrição da entrega.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Destinatário da entrega.
        /// </summary>
        [JsonPropertyName("recipient_name")]
        public string? RecipientName { get; set; }

        /// <summary>
        ///     Telefone do destinatário.
        /// </summary>
        [JsonPropertyName("recipient_phone")]
        public string? RecipientPhone { get; set; }

        /// <summary>
        ///     Endereço de entrega
        /// </summary>
        [JsonPropertyName("address")]
        public PmCreateCustomerAddressRequest? Address { get; set; }
    }
}


