namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Tipos de cobrança para assinaturas (Pré-pago ou Pós-pago).
    /// </summary>
    public static class PmBillingType
    {
        /// <summary>Pré-pago (cobranca no início do período).</summary>
        public static string Prepaid { get; set; } = "prepaid";

        /// <summary>Pós-pago (cobranca no final do período).</summary>
        public static string Postpaid { get; set; } = "postpaid";

        /// <summary>Dia exato (cobranca em um dia específico).</summary>
        public static string ExactDay { get; set; } = "exact_day";
    }
}
