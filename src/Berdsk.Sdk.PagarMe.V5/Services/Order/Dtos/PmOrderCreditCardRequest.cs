using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados sobre o pagamento com cartão de crédito
    /// </summary>
    public class PmOrderCreditCardRequest
    {
        /// <summary>
        ///     Indica se a transação deve ser capturada "auth_and_capture", autorizada "auth_only", ou pré autorizada "pre_auth".
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string? OperationType { get; set; }

        /// <summary>
        ///     Quantidade de parcelas.
        /// </summary>
        [JsonPropertyName("installments")]
        public int Installments { get; set; }

        /// <summary>
        ///     Texto exibido na fatura do cartão. Max: 22 caracteres para clientes Gateway; 13 para clientes PSP
        /// </summary>
        [JsonPropertyName("statement_descriptor")]
        public string? StatementDescriptor { get; set; }

        /// <summary>
        ///     Cartão de crédito.
        /// </summary>
        [JsonPropertyName("card")]
        public PmOrderCardRequest? Card { get; set; }

        /// <summary>
        ///     Identificador do cartão de um cliente.
        /// </summary>
        [JsonPropertyName("card_id")]
        public string? CardId { get; set; }

        /// <summary>
        ///     Token do cartão gerado pelo checkout transparente
        /// </summary>
        [JsonPropertyName("card_token")]
        public string? CardToken { get; set; }

        [JsonPropertyName("billing_address_id")]
        public string? BillingAddressId { get; set; }

        [JsonPropertyName("billing_address")] public PmCreateCustomerAddressRequest? BillingAddress { get; set; }
    }
}