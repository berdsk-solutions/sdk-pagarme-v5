namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma antecipação (anticipation) de recebível na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma antecipação.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/criar-uma-antecipa%C3%A7%C3%A3o-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmAnticipationStatus
    {
        /// <summary>Pendente de análise.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Aprovada.</summary>
        public static string Approved { get; set; } = "approved";

        /// <summary>Recusada.</summary>
        public static string Refused { get; set; } = "refused";

        /// <summary>Em construção.</summary>
        public static string Building { get; set; } = "building";

        /// <summary>Em processamento.</summary>
        public static string Processing { get; set; } = "processing";

        /// <summary>Sucesso (concluída).</summary>
        public static string Success { get; set; } = "success";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
