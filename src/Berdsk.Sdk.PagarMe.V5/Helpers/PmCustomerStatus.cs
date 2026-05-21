namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um cliente (customer) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um cliente.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-cliente-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmCustomerStatus
    {
        /// <summary>Ativo.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Deletado.</summary>
        public static string Deleted { get; set; } = "deleted";
    }
}
