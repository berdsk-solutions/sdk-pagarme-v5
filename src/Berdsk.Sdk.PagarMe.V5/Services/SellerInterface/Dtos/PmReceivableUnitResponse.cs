using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Representa uma Unidade de Recebíveis (UR) de um recebedor.
    /// </summary>
    public class PmReceivableUnitResponse
    {
        /// <summary>
        ///     Método de pagamento utilizado na transação.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     Bandeira do cartão utilizado na transação.
        /// </summary>
        [JsonPropertyName("card_brand")]
        public string CardBrand { get; set; }

        /// <summary>
        ///     Valor líquido recebido após a aplicação de taxas e descontos.
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        ///     Valor descontado devido a chargebacks (contestação de compra).
        /// </summary>
        [JsonPropertyName("chargeback_amount")]
        public long ChargebackAmount { get; set; }

        /// <summary>
        ///     Valor devolvido após a contestação de um chargeback ser bem-sucedida.
        /// </summary>
        [JsonPropertyName("chargeback_refund_amount")]
        public long ChargebackRefundAmount { get; set; }

        /// <summary>
        ///     Valor bruto total das transações antes da aplicação de taxas.
        /// </summary>
        [JsonPropertyName("credit_amount")]
        public long CreditAmount { get; set; }

        /// <summary>
        ///     Valor das taxas de operação descontadas das transações.
        /// </summary>
        [JsonPropertyName("fee_amount")]
        public long FeeAmount { get; set; }

        /// <summary>
        ///     Valor já liquidado da Unidade de Recebíveis (UR).
        /// </summary>
        [JsonPropertyName("liquidation_amount")]
        public long LiquidationAmount { get; set; }

        /// <summary>
        ///     Total de valores estornados aos clientes.
        /// </summary>
        [JsonPropertyName("refund_amount")]
        public long RefundAmount { get; set; }

        /// <summary>
        ///     Valores bloqueados por motivos de segurança.
        /// </summary>
        [JsonPropertyName("blocked_amount")]
        public long BlockedAmount { get; set; }

        /// <summary>
        ///     Data em que o pagamento será realizado.
        /// </summary>
        [JsonPropertyName("payment_date")]
        public string PaymentDate { get; set; }
    }
}