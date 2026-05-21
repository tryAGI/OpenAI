
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The currency for the threshold amount.
    /// </summary>
    public enum ProjectSpendAlertCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSpendAlertCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSpendAlertCurrency value)
        {
            return value switch
            {
                ProjectSpendAlertCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSpendAlertCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ProjectSpendAlertCurrency.Usd,
                _ => null,
            };
        }
    }
}