using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Resposta de link de pagamento.
    /// </summary>
    public class PmPaymentLinkResponse
    {
        /// <summary>
        ///     Identificador do link de pagamento.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Nome do link de pagamento.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Tipo do link de pagamento (order ou subscription).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Status do link (active, canceled, building).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        ///     URL do link de pagamento.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        ///     Data de criação.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        ///     Data de atualização.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///     Data de expiração.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        ///     Tempo de expiração em minutos.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        ///     Total de sessões geradas.
        /// </summary>
        [JsonPropertyName("total_sessions")]
        public int TotalSessions { get; set; }

        /// <summary>
        ///     Máximo de sessões permitidas.
        /// </summary>
        [JsonPropertyName("max_sessions")]
        public int? MaxSessions { get; set; }

        /// <summary>
        ///     Total de sessões pagas.
        /// </summary>
        [JsonPropertyName("total_paid_sessions")]
        public int TotalPaidSessions { get; set; }

        /// <summary>
        ///     Máximo de sessões pagas permitidas.
        /// </summary>
        [JsonPropertyName("max_paid_sessions")]
        public int? MaxPaidSessions { get; set; }

        /// <summary>
        ///     Configurações de pagamento.
        /// </summary>
        [JsonPropertyName("payment_settings")]
        public PmPaymentLinkPaymentSettingsResponse PaymentSettings { get; set; }

        /// <summary>
        ///     Configurações do carrinho.
        /// </summary>
        [JsonPropertyName("cart_settings")]
        public PmPaymentLinkCartSettingsResponse CartSettings { get; set; }

        /// <summary>
        ///     Metadados.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}


