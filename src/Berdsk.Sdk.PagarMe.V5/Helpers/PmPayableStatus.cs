namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um recebível (payable) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um recebível.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/listar-recebiveis-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmPayableStatus
    {
        /// <summary>Pago.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Aguardando liberação dos fundos.</summary>
        public static string WaitingFunds { get; set; } = "waiting_funds";

        /// <summary>Suspenso.</summary>
        public static string Suspended { get; set; } = "suspended";

        /// <summary>Pré-pago.</summary>
        public static string Prepaid { get; set; } = "prepaid";
    }
}
