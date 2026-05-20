namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transação de SafetyPay na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> da transação (<c>last_transaction</c>) de uma cobrança do tipo SafetyPay.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/safetypay-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmSafetyPayStatus
    {
        /// <summary>Pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Paga.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Paga a maior.</summary>
        public static string Overpaid { get; set; } = "overpaid";

        /// <summary>Paga a menor.</summary>
        public static string Underpaid { get; set; } = "underpaid";

        /// <summary>Com erro.</summary>
        public static string WithError { get; set; } = "with_error";

        /// <summary>Não paga.</summary>
        public static string NotPaid { get; set; } = "not_paid";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
