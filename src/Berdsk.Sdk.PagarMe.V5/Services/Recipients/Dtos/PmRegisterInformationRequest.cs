using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    /// <summary>
    ///     Informações de registro para criação de recebedor.
    /// </summary>
    public class PmRegisterInformationRequest
    {
        /// <summary>
        ///     E-mail do recebedor.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Número do documento (CPF ou CNPJ).
        /// </summary>
        [JsonPropertyName("document")]
        public string Document { get; set; }

        /// <summary>
        ///     Tipo do recebedor: "individual" (PF) ou "corporation" (PJ).
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     URL do site do recebedor.
        /// </summary>
        [JsonPropertyName("site_url")]
        public string SiteUrl { get; set; }

        /// <summary>
        ///     Nome da empresa (PJ).
        /// </summary>
        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        ///     Nome fantasia (PJ).
        /// </summary>
        [JsonPropertyName("trading_name")]
        public string TradingName { get; set; }

        /// <summary>
        ///     Receita anual (PJ).
        /// </summary>
        [JsonPropertyName("annual_revenue")]
        public long? AnnualRevenue { get; set; }

        /// <summary>
        ///     Tipo de corporação (PJ).
        /// </summary>
        [JsonPropertyName("corporation_type")]
        public string CorporationType { get; set; }

        /// <summary>
        ///     Nome completo (PF).
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Nome da mãe (PF).
        /// </summary>
        [JsonPropertyName("mother_name")]
        public string MotherName { get; set; }

        /// <summary>
        ///     Data de nascimento (PF).
        /// </summary>
        [JsonPropertyName("birthdate")]
        public string Birthdate { get; set; }

        /// <summary>
        ///     Renda mensal (PF).
        /// </summary>
        [JsonPropertyName("monthly_income")]
        public long? MonthlyIncome { get; set; }

        /// <summary>
        ///     Profissão (PF).
        /// </summary>
        [JsonPropertyName("professional_occupation")]
        public string ProfessionalOccupation { get; set; }

        /// <summary>
        ///     Endereço do recebedor.
        /// </summary>
        [JsonPropertyName("address")]
        public PmCreateAddressRequest Address { get; set; }

        /// <summary>
        ///     Telefones do recebedor.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<PmRecipientPhoneRequest> PhoneNumbers { get; set; }

        /// <summary>
        ///     Lista de sócios (PJ).
        /// </summary>
        [JsonPropertyName("managing_partners")]
        public List<PmManagingPartnerRequest> ManagingPartners { get; set; }
    }
}