namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de uma transação de cartão de crédito na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> da transação (<c>charge.last_transaction</c>) de uma cobrança do tipo cartão de crédito.
    /// </para>
    ///  <see href="https://docs.pagar.me/reference/cartão-de-crédito-1">Documentação Oficial PagarMe</see>
    /// </summary>
    public static class PmCreditCardStatus
    {
        /// <summary>Autorizada pendente de captura.</summary>
        public static string AuthorizedPendingCapture { get; set; } = "authorized_pending_capture";

        /// <summary>Não autorizada.</summary>
        public static string NotAuthorized { get; set; } = "not_authorized";

        /// <summary>Capturada.</summary>
        public static string Captured { get; set; } = "captured";

        /// <summary>Capturada parcialmente.</summary>
        public static string PartialCapture { get; set; } = "partial_capture";

        /// <summary>Aguardando captura.</summary>
        public static string WaitingCapture { get; set; } = "waiting_capture";

        /// <summary>Estornada.</summary>
        public static string Refunded { get; set; } = "refunded";

        /// <summary>Cancelada.</summary>
        public static string Voided { get; set; } = "voided";

        /// <summary>Estornada parcialmente.</summary>
        public static string PartialRefunded { get; set; } = "partial_refunded";

        /// <summary>Cancelada parcialmente.</summary>
        public static string PartialVoid { get; set; } = "partial_void";

        /// <summary>Erro no cancelamento.</summary>
        public static string ErrorOnVoiding { get; set; } = "error_on_voiding";

        /// <summary>Erro no estorno.</summary>
        public static string ErrorOnRefunding { get; set; } = "error_on_refunding";

        /// <summary>Aguardando cancelamento.</summary>
        public static string WaitingCancellation { get; set; } = "waiting_cancellation";

        /// <summary>Com erro.</summary>
        public static string WithError { get; set; } = "with_error";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
