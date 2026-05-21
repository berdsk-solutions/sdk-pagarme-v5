namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma conta bancária (bank account) de recebedor na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de uma conta bancária.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-recebedor-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmBankAccountStatus
    {
        /// <summary>Ativa.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Inativa.</summary>
        public static string Inactive { get; set; } = "inactive";

        /// <summary>Deletada.</summary>
        public static string Deleted { get; set; } = "deleted";
    }
}
