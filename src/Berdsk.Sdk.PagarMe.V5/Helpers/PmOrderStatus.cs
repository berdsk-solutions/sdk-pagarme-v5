namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um pedido (order) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um pedido (order) e de seus itens/transações.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-pedido-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmOrderStatus
    {
        /// <summary>Pendente.</summary>
        public static string Pending { get; set; } = "pending";

        /// <summary>Pago.</summary>
        public static string Paid { get; set; } = "paid";

        /// <summary>Cancelado.</summary>
        public static string Canceled { get; set; } = "canceled";

        /// <summary>Falha.</summary>
        public static string Failed { get; set; } = "failed";

        /// <summary>Fechado (usado em <c>CloseOrderAsync</c>).</summary>
        public static string Closed { get; set; } = "closed";
    }
}
