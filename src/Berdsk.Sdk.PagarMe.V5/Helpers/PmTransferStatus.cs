namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transferência (transfer) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma transferência.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-transfer%C3%AAncia-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmTransferStatus
    {
        /// <summary>Pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Em processamento.</summary>
        public static string Processing { get; set; } = "processing";

        /// <summary>Transferida com sucesso.</summary>
        public static string Transferred { get; set; } = "transferred";

        /// <summary>Falha na transferência.</summary>
        public static string Failed { get; set; } = "failed";

        /// <summary>Cancelada.</summary>
        public static string Canceled { get; set; } = "canceled";
    }
}
