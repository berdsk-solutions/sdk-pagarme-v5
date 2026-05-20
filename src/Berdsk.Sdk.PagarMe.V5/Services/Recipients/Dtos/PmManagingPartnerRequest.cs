using System.Collections.Generic;
using System.Text.Json.Serialization;
using Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmManagingPartnerRequest
    {
        [JsonPropertyName("name")] public string Name { get; set; }

        [JsonPropertyName("email")] public string Email { get; set; }

        [JsonPropertyName("document")] public string Document { get; set; }

        [JsonPropertyName("birthdate")] public string Birthdate { get; set; }

        [JsonPropertyName("monthly_income")] public long? MonthlyIncome { get; set; }

        [JsonPropertyName("professional_occupation")]
        public string ProfessionalOccupation { get; set; }

        [JsonPropertyName("self_declared_representative")]
        public bool? SelfDeclaredRepresentative { get; set; }

        [JsonPropertyName("address")] public PmCreateAddressRequest Address { get; set; }

        [JsonPropertyName("phone_numbers")] public List<PmRecipientPhoneRequest> PhoneNumbers { get; set; }
    }
}