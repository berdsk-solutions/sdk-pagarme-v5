namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transação de cartão de débito na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> da transação (<c>last_transaction</c>) de uma cobrança do tipo cartão de débito.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/cartão-de-débito-2">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmDebitCardStatus
    {
        /// <summary>Não autorizada.</summary>
        public static string NotAuthorized { get; set; } = "not_authorized";

        /// <summary>Pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Capturada.</summary>
        public static string Captured { get; set; } = "captured";

        /// <summary>Estornada.</summary>
        public static string Refunded { get; set; } = "refunded";

        /// <summary>Erro no estorno.</summary>
        public static string ErrorOnRefunding { get; set; } = "error_on_refunding";

        /// <summary>Com erro.</summary>
        public static string WithError { get; set; } = "with_error";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
