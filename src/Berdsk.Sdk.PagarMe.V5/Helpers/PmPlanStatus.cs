namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um plano (plan) ou item de plano na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um plano ou de seus itens.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-plano-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmPlanStatus
    {
        /// <summary>Ativo.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Inativo.</summary>
        public static string Inactive { get; set; } = "inactive";

        /// <summary>Deletado.</summary>
        public static string Deleted { get; set; } = "deleted";
    }
}
