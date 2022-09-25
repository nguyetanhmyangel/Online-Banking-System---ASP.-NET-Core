﻿namespace BankSystem.Common
{
    public static class EmailMessages
    {
        public const string ConfirmEmailSubject = "Online Banking System email confirmation";

        public const string EmailConfirmationMessage =
            "To access your Online Banking System account, please confirm your email by <a href=\"{0}\">clicking here</a>.";

        public const string EmailConfirmationPage = "/Account/ConfirmEmail";

        public const string ReceiveMoneySubject = "You have received money";

        public const string ReceiveMoneyMessage =
            "You have received €{0}. Please log into your Online Banking System account for additional information.";

        public const string SendMoneySubject = "You have sent money";

        public const string SendMoneyMessage =
            "You have transferred €{0} from your account. If this transaction is fraudulent, please contact our support center.";
    }
}
