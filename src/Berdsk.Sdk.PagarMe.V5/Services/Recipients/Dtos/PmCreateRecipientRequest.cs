using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Requisição para criar um novo recebedor.
    ///     <para>Referência: https://docs.pagar.me/reference/criar-recebedor-1.md</para>
    /// </summary>
    public class PmCreateRecipientRequest
    {
        /// <summary>
        ///     Código de referência externa do recebedor (único por recebedor).
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        ///     Informações de registro/cadastro do recebedor.
        /// </summary>
        [JsonPropertyName("register_information")]
        public PmRegisterInformationRequest RegisterInformation { get; set; }

        /// <summary>
        ///     Dados da conta bancária padrão do recebedor.
        /// </summary>
        [JsonPropertyName("default_bank_account")]
        public PmCreateBankAccountRequest DefaultBankAccount { get; set; }

        /// <summary>
        ///     Configurações de transferência do recebedor.
        /// </summary>
        [JsonPropertyName("transfer_settings")]
        public PmTransferSettingsRequest TransferSettings { get; set; }

        /// <summary>
        ///     Configurações de antecipação automática do recebedor.
        /// </summary>
        [JsonPropertyName("automatic_anticipation_settings")]
        public PmAnticipationSettingsRequest AutomaticAnticipationSettings { get; set; }

        /// <summary>
        ///     Metadados associados ao recebedor.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}