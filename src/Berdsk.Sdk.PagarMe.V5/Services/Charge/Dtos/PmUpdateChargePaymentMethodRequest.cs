using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Requisição para editar o método de pagamento de uma cobrança
    /// </summary>
    public class PmUpdateChargePaymentMethodRequest
    {
        /// <summary>
        ///     Novo método de pagamento (credit_card, boleto, voucher, debit_card, cash, pix)
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Dados do cartão de crédito (Obrigatório se payment_method for credit_card)
        /// </summary>
        [JsonPropertyName("credit_card")]
        public PmOrderCreditCardRequest? CreditCard { get; set; }

        /// <summary>
        ///     Dados do boleto (Obrigatório se payment_method for boleto)
        /// </summary>
        [JsonPropertyName("boleto")]
        public object? Boleto { get; set; }

        /// <summary>
        ///     Dados do voucher (Obrigatório se payment_method for voucher)
        /// </summary>
        [JsonPropertyName("voucher")]
        public object? Voucher { get; set; }

        /// <summary>
        ///     Dados do cartão de débito (Obrigatório se payment_method for debit_card)
        /// </summary>
        [JsonPropertyName("debit_card")]
        public object? DebitCard { get; set; }

        /// <summary>
        ///     Dados do PIX (Obrigatório se payment_method for pix)
        /// </summary>
        [JsonPropertyName("pix")]
        public object? Pix { get; set; }
    }
}


