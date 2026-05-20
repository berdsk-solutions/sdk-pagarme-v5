using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace Berdsk.Sdk.PagarMe.V5.Services.PaymentLink.Dtos
{
    /// <summary>
    ///     Requisição para criação de link de pagamento.
    /// </summary>
    public class PmCreatePaymentLinkRequest
    {
        /// <summary>
        ///     Define se o link de pagamento será criado com o status building ou ativo. Default: false.
        /// </summary>
        [JsonPropertyName("is_building")]
        public bool IsBuilding { get; set; }

        /// <summary>
        ///     Nome do link de pagamento. Max: 64 caracteres.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Identificador do lojista para correlação.
        /// </summary>
        [JsonPropertyName("order_code")]
        public string? OrderCode { get; set; }

        /// <summary>
        ///     Tipo do link de pagamento. Valores possíveis: "order", "subscription".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = "order";

        /// <summary>
        ///     Data de expiração no formato ISO 8601.
        /// </summary>
        [JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        ///     Tempo de expiração em minutos após o link estar ativo.
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        ///     Máximo de pedidos que o link pode gerar.
        /// </summary>
        [JsonPropertyName("max_sessions")]
        public int? MaxSessions { get; set; }

        /// <summary>
        ///     Máximo de pedidos pagos que o link pode gerar.
        /// </summary>
        [JsonPropertyName("max_paid_sessions")]
        public int? MaxPaidSessions { get; set; }

        /// <summary>
        ///     Configurações de pagamento.
        /// </summary>
        [JsonPropertyName("payment_settings")]
        public PmPaymentLinkPaymentSettingsRequest PaymentSettings { get; set; }

        /// <summary>
        ///     Configurações do carrinho.
        /// </summary>
        [JsonPropertyName("cart_settings")]
        public PmPaymentLinkCartSettingsRequest CartSettings { get; set; }

        /// <summary>
        ///     Configurações de cliente (opcional).
        /// </summary>
        [JsonPropertyName("customer_settings")]
        public PmPaymentLinkCustomerSettingsRequest? CustomerSettings { get; set; }

        /// <summary>
        ///     Metadados adicionais.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}


