using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos
{
    /// <summary>
    ///     Opções da regra de split.
    /// </summary>
    public class PmSplitOptionsRequest
    {
        /// <summary>
        ///     Indica se o recebedor vinculado Ã  regra será cobrado pelas taxas da transação.
        /// </summary>
        [JsonPropertyName("charge_processing_fee")]
        public bool? ChargeProcessingFee { get; set; }

        /// <summary>
        ///     Indica se o recebedor vinculado Ã  regra irá receber o restante dos recebíveis após uma divisão.
        /// </summary>
        [JsonPropertyName("charge_remainder_fee")]
        public bool? ChargeRemainderFee { get; set; }

        /// <summary>
        ///     Indica se o recebedor é responsável pela transação em caso de chargeback.
        /// </summary>
        [JsonPropertyName("liable")]
        public bool? Liable { get; set; }
    }
}


