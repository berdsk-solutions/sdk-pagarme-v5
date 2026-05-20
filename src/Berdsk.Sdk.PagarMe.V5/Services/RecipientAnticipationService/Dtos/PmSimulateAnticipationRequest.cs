using System;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.RecipientAnticipationService.Dtos
{
    /// <summary>
    ///     Requisição para simular uma antecipação.
    /// </summary>
    public class PmSimulateAnticipationRequest
    {
        /// <summary>
        ///     Data de pagamento da antecipação. Data no formato ISO 8601.
        /// </summary>
        [JsonPropertyName("payment_date")]
        public DateTime PaymentDate { get; set; }

        /// <summary>
        ///     Define o período de onde os recebíveis serão escolhidos. start ou end.
        /// </summary>
        [JsonPropertyName("timeframe")]
        public string Timeframe { get; set; }

        /// <summary>
        ///     Valor líquido, em centavos, que você deseja receber de antecipação.
        /// </summary>
        [JsonPropertyName("requested_amount")]
        public long RequestedAmount { get; set; }
    }
}