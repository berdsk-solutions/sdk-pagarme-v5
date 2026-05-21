namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma operação de saldo (balance operation) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma operação de saldo / movimentação.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/listar-opera%C3%A7%C3%B5es-de-saldo-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmBalanceOperationStatus
    {
        /// <summary>Aguardando liberação dos fundos.</summary>
        public static string WaitingFunds { get; set; } = "waiting_funds";

        /// <summary>Disponível para saque.</summary>
        public static string Available { get; set; } = "available";

        /// <summary>Já transferido.</summary>
        public static string Transferred { get; set; } = "transferred";
    }
}
