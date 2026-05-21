namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transação de Pix na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> da transação (<c>last_transaction</c>) de uma cobrança do tipo pix.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/pix-2">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmPixStatus
    {
        /// <summary>Aguardando pagamento.</summary>
        public static string WaitingPayment { get; set; } = "waiting_payment";

        /// <summary>Pago.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Aguardando estorno.</summary>
        public static string PendingRefund { get; set; } = "pending_refund";

        /// <summary>Estornado.</summary>
        public static string Refunded { get; set; } = "refunded";

        /// <summary>Com erro.</summary>
        public static string WithError { get; set; } = "with_error";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
