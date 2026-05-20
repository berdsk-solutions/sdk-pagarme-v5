using System.Text.Json.Serialization;

namespace Berdsk.Sdk.PagarMe.V5.Services.PlanItem.Dtos
{
    /// <summary>
    ///     Requisição para criar um item em um plano.
    /// </summary>
    public class PmCreatePlanItemRequest
    {
        /// <summary>
        ///     Nome do item. <br />
        ///     Max: 64 caracteres.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Descrição do item. <br />
        ///     Max: 256 caracteres.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///     Número de ciclos durante o qual o item será cobrado. <br />
        ///     Ex: Um item com cycles = 1 representa que um item será cobrado apenas uma vez. <br />
        ///     Caso não seja informado, o item será cobrado até que seja desativado.
        /// </summary>
        [JsonPropertyName("cycles")]
        public int? Cycles { get; set; }

        /// <summary>
        ///     Preço unitário do item em centavos.
        /// </summary>
        [JsonPropertyName("price")]
        public int? Price { get; set; }

        /// <summary>
        ///     Quantidade de itens.
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        ///     Código de referência do item no seu sistema.
        /// </summary>
        [JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        ///     Configurações de preço (tier, volume, etc).
        /// </summary>
        [JsonPropertyName("pricing_scheme")]
        public PmPlanItemPricingSchemeRequest? PricingScheme { get; set; }
    }
}