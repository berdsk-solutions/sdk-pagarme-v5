namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um endereço (address) de cliente na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um endereço.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-endere%C3%A7o-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmAddressStatus
    {
        /// <summary>Ativo.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Deletado.</summary>
        public static string Deleted { get; set; } = "deleted";
    }
}
