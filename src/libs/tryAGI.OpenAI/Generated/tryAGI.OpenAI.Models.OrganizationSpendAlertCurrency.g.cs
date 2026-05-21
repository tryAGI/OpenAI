
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The currency for the threshold amount.
    /// </summary>
    public enum OrganizationSpendAlertCurrency
    {
        /// <summary>
        /// 
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSpendAlertCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSpendAlertCurrency value)
        {
            return value switch
            {
                OrganizationSpendAlertCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSpendAlertCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => OrganizationSpendAlertCurrency.Usd,
                _ => null,
            };
        }
    }
}