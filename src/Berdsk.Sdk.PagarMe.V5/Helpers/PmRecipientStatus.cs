namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Helper estático com os possíveis status (string) de um recebedor (recipient) na API PagarMe v5.
    /// <para>
    /// Use estas constantes em vez de digitar a string do status manualmente, evitando erros de digitação
    /// ao comparar o campo <c>status</c> de um recebedor.
    /// </para>
    /// <para>
    /// <see href="https://docs.pagar.me/reference/obter-recebedor-1">Documentação Oficial PagarMe</see>
    /// </para>
    /// </summary>
    public static class PmRecipientStatus
    {
        /// <summary>Em cadastro.</summary>
        public static string Registration { get; set; } = "registration";

        /// <summary>Em afiliação.</summary>
        public static string Affiliation { get; set; } = "affiliation";

        /// <summary>Ativo.</summary>
        public static string Active { get; set; } = "active";

        /// <summary>Recusado.</summary>
        public static string Refused { get; set; } = "refused";

        /// <summary>Suspenso.</summary>
        public static string Suspended { get; set; } = "suspended";

        /// <summary>Bloqueado.</summary>
        public static string Blocked { get; set; } = "blocked";

        /// <summary>Inativo.</summary>
        public static string Inactive { get; set; } = "inactive";
    }
}
