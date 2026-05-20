using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Order.Dtos
{
    /// <summary>
    ///     Dados sobre o pagamento com Pix
    /// </summary>
    public class PmOrderPixRequest
    {
        /// <summary>
        ///     Data de expiração do Pix em segundos.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        ///     Data de expiração do Pix.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        ///     Informações adicionais do Pix.
        /// </summary>
        [JsonPropertyName("additional_information")]
        public List<PmOrderPixAdditionalInformationRequest>? AdditionalInformation { get; set; }
    }

    /// <summary>
    ///     Informações adicionais do Pix
    /// </summary>
    public class PmOrderPixAdditionalInformationRequest
    {
        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("value")] public string Value { get; set; }
    }
}