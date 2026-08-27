
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum SpendLimitCurrencyEnum
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpendLimitCurrencyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitCurrencyEnum value)
        {
            return value switch
            {
                SpendLimitCurrencyEnum.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitCurrencyEnum? ToEnum(string value)
        {
            return value switch
            {
                "USD" => SpendLimitCurrencyEnum.Usd,
                _ => null,
            };
        }
    }
}