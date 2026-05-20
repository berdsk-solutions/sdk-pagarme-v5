namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de entrega de um webhook na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> retornado em consultas/listagens de webhooks.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/listar-webhooks-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmWebhookDeliveryStatus
    {
        /// <summary>Pendente de entrega.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Enviado com sucesso.</summary>
        public static string Sent { get; set; } = "sent";

        /// <summary>Falha na entrega.</summary>
        public static string Failed { get; set; } = "failed";
    }
}
