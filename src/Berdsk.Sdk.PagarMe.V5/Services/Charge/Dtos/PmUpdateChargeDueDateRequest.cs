using System.Text.Json.Serialization;
using System;
namespace Berdsk.Sdk.PagarMe.V5.Services.Charge.Dtos
{
    /// <summary>
    ///     Requisição para editar a data de vencimento de uma cobrança
    /// </summary>
    public class PmUpdateChargeDueDateRequest
    {
        /// <summary>
        ///     Nova data de vencimento
        /// </summary>
        [JsonPropertyName("due_at")]
        public DateTime DueAt { get; set; }
    }
}


