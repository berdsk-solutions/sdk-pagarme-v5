using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Representa um titular de ativos ou credor.
    /// </summary>
    public class PmContestationAssetHolderRequest
    {
        /// <summary>
        ///     Nome.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Documento.
        /// </summary>
        [JsonPropertyName("document")]
        public string Document { get; set; }
    }
}