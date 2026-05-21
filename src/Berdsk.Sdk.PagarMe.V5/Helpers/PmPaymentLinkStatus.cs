namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um Payment Link na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um Payment Link.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/listar-payment-links-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmPaymentLinkStatus
    {
        /// <summary>Ativo.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Cancelado.</summary>
        public static string Canceled { get; set; } = "canceled";

        /// <summary>Em construção (ainda sendo gerado).</summary>
        public static string Building { get; set; } = "building";
    }
}
