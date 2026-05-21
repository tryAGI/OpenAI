
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The currency for the threshold amount.
    /// </summary>
    public enum CreateSpendAlertBodyCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpendAlertBodyCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpendAlertBodyCurrency value)
        {
            return value switch
            {
                CreateSpendAlertBodyCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpendAlertBodyCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => CreateSpendAlertBodyCurrency.Usd,
                _ => null,
            };
        }
    }
}