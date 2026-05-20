using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmRegisterInformationResponse
    {
        [JsonPropertyName("company_name")] public string CompanyName { get; set; }

        [JsonPropertyName("trading_name")] public string TradingName { get; set; }

        [JsonPropertyName("annual_revenue")] public long? AnnualRevenue { get; set; }

        [JsonPropertyName("corporation_type")] public string CorporationType { get; set; }

        [JsonPropertyName("email")] public string Email { get; set; }

        [JsonPropertyName("document")] public string Document { get; set; }

        [JsonPropertyName("type")] public string Type { get; set; }

        [JsonPropertyName("site_url")] public string SiteUrl { get; set; }

        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("mother_name")] public string MotherName { get; set; }

        [JsonPropertyName("birthdate")] public string Birthdate { get; set; }

        [JsonPropertyName("monthly_income")] public long? MonthlyIncome { get; set; }

        [JsonPropertyName("professional_occupation")]
        public string ProfessionalOccupation { get; set; }
    }
}


