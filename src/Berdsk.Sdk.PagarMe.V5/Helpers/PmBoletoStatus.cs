namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transação de boleto na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> da transação (<c>last_transaction</c>) de uma cobrança do tipo boleto.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/boleto-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmBoletoStatus
    {
        /// <summary>Gerado.</summary>
        public static string Generated { get; set; } = "generated";

        /// <summary>Visualizado.</summary>
        public static string Viewed { get; set; } = "viewed";

        /// <summary>Pago a menor.</summary>
        public static string Underpaid { get; set; } = "underpaid";

        /// <summary>Pago a maior.</summary>
        public static string Overpaid { get; set; } = "overpaid";

        /// <summary>Pago.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Cancelado.</summary>
        public static string Voided { get; set; } = "voided";

        /// <summary>Com erro.</summary>
        public static string WithError { get; set; } = "with_error";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";

        /// <summary>Boleto ainda está em etapa de criação.</summary>
        public static string Processing { get; set; } = "processing";
    }
}
