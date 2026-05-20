using System.Text.Json.Serialization;
namespace Berdsk.Sdk.PagarMe.V5.Services.SellerInterface.Dtos
{
    /// <summary>
    ///     Autor da contestação.
    /// </summary>
    public class PmContestationAuthorRequest
    {
        /// <summary>
        ///     Seu e-mail cadastrado no Pagar.me.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Sistema originador da contestação. Sempre utilizar "API".
        /// </summary>
        [JsonPropertyName("system")]
        public string System { get; set; } = "API";

        /// <summary>
        ///     Nome da sua empresa no Pagar.me.
        /// </summary>
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}


