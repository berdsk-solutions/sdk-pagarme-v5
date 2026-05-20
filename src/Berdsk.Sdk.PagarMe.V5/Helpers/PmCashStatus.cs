namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transação de Cash (dinheiro) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> da transação (<c>last_transaction</c>) de uma cobrança do tipo cash.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/cash-2">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmCashStatus
    {
        /// <summary>Pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Paga.</summary>
        public static string Paid { get; set; } = "paid";
    }
}
