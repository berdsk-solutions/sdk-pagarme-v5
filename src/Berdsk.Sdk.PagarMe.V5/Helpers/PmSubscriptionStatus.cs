namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma assinatura na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma assinatura (subscription).
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/criar-assinatura-de-plano-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmSubscriptionStatus
    {
        /// <summary>Assinatura ativa.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Assinatura cancelada.</summary>
        public static string Canceled { get; set; } = "canceled";

        /// <summary>Assinatura futura (ainda não iniciada).</summary>
        public static string Future { get; set; } = "future";
    }
}
