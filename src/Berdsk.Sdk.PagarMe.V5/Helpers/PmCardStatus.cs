namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um cartão (card) de cliente na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um cartão salvo do cliente.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-cart%C3%A3o-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmCardStatus
    {
        /// <summary>Ativo.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Deletado.</summary>
        public static string Deleted { get; set; } = "deleted";

        /// <summary>Expirado.</summary>
        public static string Expired { get; set; } = "expired";
    }
}
