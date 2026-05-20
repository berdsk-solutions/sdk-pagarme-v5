namespace Berdsk.Sdk.PagarMe.V5
{
    public static class PmEndpoints
    {
        public static class Settlements
        {
            public const string Base = "settlements";
            public const string Get = "settlements/{0}";
        }

        public static class Transfers
        {
            public const string Base = "transfers";
            public const string Get = "transfers/{0}";
            public const string Receipt = "transfers/{0}/receipt";
        }

        public static class Customers
        {
            public const string Base = "customers";
            public const string Get = "customers/{0}";
            public const string Update = "customers/{0}";
        }

        public static class Cards
        {
            public const string Base = "customers/{0}/cards";
            public const string Get = "customers/{0}/cards/{1}";
            public const string Update = "customers/{0}/cards/{1}";
            public const string Delete = "customers/{0}/cards/{1}";
            public const string Renew = "customers/{0}/cards/{1}/renew";
        }

        public static class Tokens
        {
            public const string Base = "tokens";
        }

        public static class Addresses
        {
            public const string Base = "customers/{0}/addresses";
            public const string Get = "customers/{0}/addresses/{1}";
            public const string Update = "customers/{0}/addresses/{1}";
            public const string Delete = "customers/{0}/addresses/{1}";
        }

        public static class CardBin
        {
            public const string Base = "https://api.pagar.me/bin/v1/{0}";
        }

        public static class Orders
        {
            public const string Base = "orders";
            public const string Get = "orders/{0}";
            public const string Close = "orders/{0}/closed";
            public const string AddCharge = "orders/{0}/charges";
        }

        public static class Charges
        {
            public const string Base = "charges";
            public const string Get = "charges/{0}";
            public const string Capture = "charges/{0}/capture";
            public const string UpdateCard = "charges/{0}/card";
            public const string UpdateDueDate = "charges/{0}/due-date";
            public const string UpdatePaymentMethod = "charges/{0}/payment-method";
            public const string Cancel = "charges/{0}";
            public const string Retry = "charges/{0}/retry";
            public const string ConfirmCash = "charges/{0}/confirm-payment";
        }

        public static class OrderItems
        {
            public const string Base = "orders/{0}/items";
            public const string Get = "orders/{0}/items/{1}";
            public const string Update = "orders/{0}/items/{1}";
            public const string Delete = "orders/{0}/items/{1}";
            public const string DeleteAll = "orders/{0}/items";
        }

        public static class PaymentLinks
        {
            public const string Base = "paymentlinks";
            public const string Get = "paymentlinks/{0}";
            public const string Cancel = "paymentlinks/{0}";
        }

        public static class Plans
        {
            public const string Base = "plans";
            public const string Get = "plans/{0}";
            public const string Update = "plans/{0}";
            public const string Delete = "plans/{0}";
            public const string UpdateMetadata = "plans/{0}/metadata";
        }

        public static class Subscriptions
        {
            public const string Base = "subscriptions";
            public const string Get = "subscriptions/{0}";
            public const string Update = "subscriptions/{0}";
            public const string Cancel = "subscriptions/{0}";
            public const string UpdateCard = "subscriptions/{0}/card";
            public const string UpdateMetadata = "subscriptions/{0}/metadata";
            public const string UpdatePaymentMethod = "subscriptions/{0}/payment-method";
            public const string UpdateStartAt = "subscriptions/{0}/start-at";
            public const string UpdateMinimumPrice = "subscriptions/{0}/minimum-price";
            public const string ManualBilling = "subscriptions/{0}/manual-billing";
        }

        public static class SubscriptionItems
        {
            public const string Base = "subscriptions/{0}/items";
            public const string Get = "subscriptions/{0}/items/{1}";
            public const string Update = "subscriptions/{0}/items/{1}";
            public const string Delete = "subscriptions/{0}/items/{1}";
        }

        public static class PlanItems
        {
            public const string Base = "plans/{0}/items";
            public const string Get = "plans/{0}/items/{1}";
            public const string Update = "plans/{0}/items/{1}";
            public const string Delete = "plans/{0}/items/{1}";
        }

        public static class SubscriptionCycles
        {
            public const string Base = "subscriptions/{0}/cycles";
            public const string Get = "subscriptions/{0}/cycles/{1}";
            public const string Renew = "subscriptions/{0}/cycles";
            public const string Pay = "subscriptions/{0}/cycles/{1}/pay";
        }

        public static class SubscriptionDiscounts
        {
            public const string Base = "subscriptions/{0}/discounts";
            public const string Get = "subscriptions/{0}/discounts/{1}";
            public const string Delete = "subscriptions/{0}/discounts/{1}";
        }

        public static class SubscriptionIncrements
        {
            public const string Base = "subscriptions/{0}/increments";
            public const string Get = "subscriptions/{0}/increments/{1}";
            public const string Delete = "subscriptions/{0}/increments/{1}";
        }

        public static class SubscriptionInvoices
        {
            public const string Base = "subscriptions/{0}/invoices";
            public const string Get = "invoices/{0}";
            public const string ListAll = "invoices";
        }

        public static class SubscriptionItemUsage
        {
            public const string Base = "subscriptions/{0}/items/{1}/usages";
            public const string Get = "subscriptions/{0}/items/{1}/usages/{2}";
        }

        public static class SubscriptionSplit
        {
            public const string Base = "subscriptions/{0}/split";
        }

        public static class Payables
        {
            public const string Base = "payables";
        }

        public static class BalanceOperations
        {
            public const string Base = "balance/operations";
            public const string Get = "balance/operations/{0}";
        }

        public static class Recipients
        {
            public const string Base = "recipients";
            public const string Get = "recipients/{0}";
            public const string Update = "recipients/{0}";
            public const string UpdateCode = "recipients/{0}/code";
            public const string UpdateTransferSettings = "recipients/{0}/transfer-settings";
            public const string Balance = "recipients/{0}/balance";
            public const string Anticipations = "recipients/{0}/bulk_anticipations";
            public const string GetAnticipation = "recipients/{0}/bulk_anticipations/{1}";
            public const string SimulateAnticipation = "recipients/{0}/bulk_anticipations/simulate";
            public const string AnticipationLimits = "recipients/{0}/bulk_anticipations/limits";
            public const string CancelAnticipation = "recipients/{0}/bulk_anticipations/{1}/cancel";
            public const string UpdateAutomaticAnticipationSettings = "recipients/{0}/automatic-anticipation-settings";
            public const string ReceivableUnits = "recipients/{0}/receivable-units";
            public const string Settlements = "recipients/{0}/settlements";
        }

        public static class SellerInterface
        {
            public const string SettlementObligations = "https://api.pagar.me/register/v5/settlement-obligations";
            public const string Contracts = "https://api.pagar.me/register/v5/settlement_obligations/contracts";
            public const string Contestations = "https://api.pagar.me/register/v5/contestations";
        }

        public static class RecipientBankAccounts
        {
            public const string Update = "recipients/{0}/default-bank-account";
        }

        public static class Hooks
        {
            public const string Base = "hooks";
            public const string Get = "hooks/{0}";
            public const string Retry = "hooks/{0}/retry";
        }

        public static class Disputes
        {
            public const string Base = "https://api.stone.com.br/v1/disputes";
            public const string Get = "https://api.stone.com.br/v1/disputes/{0}";
        }
    }
}
