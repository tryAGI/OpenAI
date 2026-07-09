
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `timeout`.<br/>
    /// Default Value: timeout
    /// </summary>
    public enum BetaFunctionShellCallOutputTimeoutOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallOutputTimeoutOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputTimeoutOutcomeType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputTimeoutOutcomeType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputTimeoutOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "timeout" => BetaFunctionShellCallOutputTimeoutOutcomeType.Timeout,
                _ => null,
            };
        }
    }
}