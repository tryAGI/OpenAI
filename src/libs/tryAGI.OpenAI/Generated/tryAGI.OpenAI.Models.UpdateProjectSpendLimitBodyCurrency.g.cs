
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The currency for the threshold amount. Currently, only `USD` is supported.
    /// </summary>
    public enum UpdateProjectSpendLimitBodyCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectSpendLimitBodyCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectSpendLimitBodyCurrency value)
        {
            return value switch
            {
                UpdateProjectSpendLimitBodyCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectSpendLimitBodyCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => UpdateProjectSpendLimitBodyCurrency.Usd,
                _ => null,
            };
        }
    }
}