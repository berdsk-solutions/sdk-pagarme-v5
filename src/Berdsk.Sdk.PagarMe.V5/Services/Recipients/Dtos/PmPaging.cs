using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.Recipients.Dtos
{
    public class PmPaging
    {
        [JsonPropertyName("total")] public int Total { get; set; }
    }
}


