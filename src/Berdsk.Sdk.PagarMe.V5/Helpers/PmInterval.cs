namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Intervalos de recorrência para assinaturas e planos.
    /// </summary>
    public static class PmInterval
    {
        /// <summary>Diário.</summary>
        public static string Day { get; set; } = "day";

        /// <summary>Semanal.</summary>
        public static string Week { get; set; } = "week";

        /// <summary>Mensal.</summary>
        public static string Month { get; set; } = "month";

        /// <summary>Anual.</summary>
        public static string Year { get; set; } = "year";
    }
}
