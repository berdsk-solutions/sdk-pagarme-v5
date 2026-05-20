namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma fatura (invoice) de assinatura na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma fatura (invoice) de assinatura.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-fatura-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmSubscriptionInvoiceStatus
    {
        /// <summary>Fatura pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Fatura paga.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Fatura cancelada.</summary>
        public static string Canceled { get; set; } = "canceled";

        /// <summary>Fatura agendada.</summary>
        public static string Scheduled { get; set; } = "scheduled";

        /// <summary>Fatura com falha.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
