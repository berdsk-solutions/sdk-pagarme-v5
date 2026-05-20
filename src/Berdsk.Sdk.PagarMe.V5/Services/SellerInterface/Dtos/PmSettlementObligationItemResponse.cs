using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Detalhes de uma obrigação de liquidação.
    /// </summary>
    public class PmSettlementObligationItemResponse
    {
        /// <summary>
        ///     Arranjo de pagamento.
        /// </summary>
        [JsonPropertyName("payment_scheme")]
        public string PaymentScheme { get; set; }

        /// <summary>
        ///     Valor total.
        /// </summary>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        ///     Valor não comprometido.
        /// </summary>
        [JsonPropertyName("uncommitted_amount")]
        public long UncommittedAmount { get; set; }

        /// <summary>
        ///     Data esperada de liquidação.
        /// </summary>
        [JsonPropertyName("expected_settlement_date")]
        public string ExpectedSettlementDate { get; set; }

        /// <summary>
        ///     Chave do contrato.
        /// </summary>
        [JsonPropertyName("contract_Key")]
        public string ContractKey { get; set; }

        /// <summary>
        ///     Credor do contrato.
        /// </summary>
        [JsonPropertyName("contract_holder")]
        public string ContractHolder { get; set; }

        /// <summary>
        ///     Prioridade do efeito.
        /// </summary>
        [JsonPropertyName("effect_priority")]
        public int EffectPriority { get; set; }

        /// <summary>
        ///     Tipo de contrato.
        /// </summary>
        [JsonPropertyName("contract_type")]
        public string ContractType { get; set; }

        /// <summary>
        ///     Método de divisão.
        /// </summary>
        [JsonPropertyName("division_method")]
        public string DivisionMethod { get; set; }

        /// <summary>
        ///     Valor do efeito.
        /// </summary>
        [JsonPropertyName("effect_amount")]
        public long EffectAmount { get; set; }

        /// <summary>
        ///     Valor do efeito comprometido.
        /// </summary>
        [JsonPropertyName("committed_effect_amount")]
        public long CommittedEffectAmount { get; set; }
    }
}


