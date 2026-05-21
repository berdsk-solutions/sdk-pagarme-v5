namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma cobrança (charge) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma cobrança (charge).
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-charge-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmChargeStatus
    {
        /// <summary>Pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Paga.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Cancelada.</summary>
        public static string Canceled { get; set; } = "canceled";

        /// <summary>Em processamento.</summary>
        public static string Processing { get; set; } = "processing";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";

        /// <summary>Paga a maior.</summary>
        public static string Overpaid { get; set; } = "overpaid";

        /// <summary>Paga a menor.</summary>
        public static string Underpaid { get; set; } = "underpaid";

        /// <summary>Chargeback (disputa/contestação).</summary>
        public static string Chargedback { get; set; } = "chargedback";
    }
}
