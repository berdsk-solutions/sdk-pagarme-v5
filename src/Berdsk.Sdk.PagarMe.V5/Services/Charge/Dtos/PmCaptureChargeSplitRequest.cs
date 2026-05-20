using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Common.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Requisição para capturar uma cobrança com split.
    /// </summary>
    public class PmCaptureChargeSplitRequest
    {
        /// <summary>
        ///     Valor a ser capturado. Caso não seja informado, será considerado o valor total da cobrança.
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }

        /// <summary>
        ///     Lista de regras de split.
        /// </summary>
        [JsonPropertyName("split")]
        public List<PmSplitRequest> Split { get; set; } = new List<PmSplitRequest>();
    }
}