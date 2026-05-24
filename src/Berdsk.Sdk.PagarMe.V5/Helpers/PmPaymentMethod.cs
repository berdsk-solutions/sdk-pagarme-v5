namespace Berdsk.Sdk.PagarMe.V5.Helpers
{
    /// <summary>
    /// Meios de pagamento suportados pela PagarMe V5.
    /// </summary>
    public static class PmPaymentMethod
    {
        /// <summary>Cartão de Crédito.</summary>
        public static string CreditCard { get; set; } = "credit_card";

        /// <summary>Cartão de Débito.</summary>
        public static string DebitCard { get; set; } = "debit_card";

        /// <summary>Boleto Bancário.</summary>
        public static string Boleto { get; set; } = "boleto";

        /// <summary>Pix.</summary>
        public static string Pix { get; set; } = "pix";

        /// <summary>Voucher (Cartão de Benefício).</summary>
        public static string Voucher { get; set; } = "voucher";

        /// <summary>Transferência Bancária.</summary>
        public static string BankTransfer { get; set; } = "bank_transfer";

        /// <summary>SafetyPay.</summary>
        public static string SafetyPay { get; set; } = "safetypay";

        /// <summary>Checkout PagarMe.</summary>
        public static string Checkout { get; set; } = "checkout";

        /// <summary>Dinheiro (Cash).</summary>
        public static string Cash { get; set; } = "cash";
    }
}
