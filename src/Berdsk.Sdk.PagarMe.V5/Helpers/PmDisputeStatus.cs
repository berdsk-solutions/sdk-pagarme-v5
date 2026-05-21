namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma disputa (chargeback/dispute) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma disputa (também usado em <c>Contestation</c> da Seller Interface).
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-uma-disputa-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmDisputeStatus
    {
        /// <summary>Aberta.</summary>
        public static string Opened { get; set; } = "opened";

        /// <summary>Aguardando contestação do estabelecimento.</summary>
        public static string WaitingMerchantResponse { get; set; } = "waiting_merchant_response";

        /// <summary>Em análise.</summary>
        public static string UnderAnalysis { get; set; } = "under_analysis";

        /// <summary>Aceita pelo estabelecimento.</summary>
        public static string Accepted { get; set; } = "accepted";

        /// <summary>Contestada.</summary>
        public static string Contested { get; set; } = "contested";

        /// <summary>Ganha pelo estabelecimento.</summary>
        public static string Won { get; set; } = "won";

        /// <summary>Perdida pelo estabelecimento.</summary>
        public static string Lost { get; set; } = "lost";

        /// <summary>Fechada.</summary>
        public static string Closed { get; set; } = "closed";
    }
}
