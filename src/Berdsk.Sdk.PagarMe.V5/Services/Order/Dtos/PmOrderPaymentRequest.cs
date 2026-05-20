using System.Text.Json.Serialization;
using System.Collections.Generic;
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados de pagamento
    /// </summary>
    public class PmOrderPaymentRequest
    {
        /// <summary>
        ///     Meio de pagamento. Valores possíveis: credit_card, boleto, Pix, Debit Card
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Dados sobre o pagamento com cartão de crédito
        /// </summary>
        [JsonPropertyName("credit_card")]
        public PmOrderCreditCardRequest? CreditCard { get; set; }

        /// <summary>
        ///     Dados sobre o pagamento com boleto
        /// </summary>
        [JsonPropertyName("boleto")]
        public PmOrderBoletoRequest? Boleto { get; set; }

        /// <summary>
        ///     Dados sobre o pagamento com cartão de débito
        /// </summary>
        [JsonPropertyName("debit_card")]
        public PmOrderDebitCardRequest? DebitCard { get; set; }

        /// <summary>
        ///     Dados para o split de pagamentos
        /// </summary>
        [JsonPropertyName("split")]
        public List<PmSplitRequest>? Split { get; set; }
    }
}


