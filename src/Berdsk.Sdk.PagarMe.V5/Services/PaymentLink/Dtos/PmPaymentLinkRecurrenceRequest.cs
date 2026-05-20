using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Recorrência no link de pagamento.
    /// </summary>
    public class PmPaymentLinkRecurrenceRequest
    {
        /// <summary>
        ///     Quantidade de dias para iniciar a cobrança.
        /// </summary>
        [JsonPropertyName("start_in")]
        public int? StartIn { get; set; }

        /// <summary>
        ///     Identificador do plano.
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}