namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma Settlement (liquidação) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma settlement.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-settlement-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmSettlementsStatus
    {
        /// <summary>Falha na liquidação.</summary>
        public static string Failed { get; set; } = "failed";

        /// <summary>Liquidação realizada com sucesso.</summary>
        public static string Success { get; set; } = "success";

        /// <summary>Liquidação pendente.</summary>
        public static string Pending { get; set; } = "pending";
    }
}
