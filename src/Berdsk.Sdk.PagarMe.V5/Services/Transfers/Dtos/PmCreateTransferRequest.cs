using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Transfers.Dtos
{
    /// <summary>
    ///     Requisição para criar uma transferência.
    ///     <see href="https://docs.pagar.me/reference/criando-uma-transferência">Documentação Oficial PagarMe</see>
    /// </summary>
    public class PmCreateTransferRequest
    {
        /// <summary>
        ///     Valor, em centavos, a ser transferido para uma determinada conta bancária (valor precisa estar entre 1 e
        ///     2147483647)
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        ///     Indica que o valor da transferência sairá da conta do recebedor identificado por este parâmetro.
        ///     OBS: Caso o recipient_id seja passado, não é necessário passar bank_account_id
        /// </summary>
        [JsonPropertyName("recipient_id")]
        public string? RecipientId { get; set; }

        /// <summary>
        ///     Você pode passar dados adicionais na criação da transferência para facilitar uma futura análise de dados por seus
        ///     sistemas.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
    }
}