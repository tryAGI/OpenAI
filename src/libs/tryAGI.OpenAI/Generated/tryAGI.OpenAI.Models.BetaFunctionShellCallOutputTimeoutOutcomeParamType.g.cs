
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `timeout`.<br/>
    /// Default Value: timeout
    /// </summary>
    public enum BetaFunctionShellCallOutputTimeoutOutcomeParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionShellCallOutputTimeoutOutcomeParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionShellCallOutputTimeoutOutcomeParamType value)
        {
            return value switch
            {
                BetaFunctionShellCallOutputTimeoutOutcomeParamType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionShellCallOutputTimeoutOutcomeParamType? ToEnum(string value)
        {
            return value switch
            {
                "timeout" => BetaFunctionShellCallOutputTimeoutOutcomeParamType.Timeout,
                _ => null,
            };
        }
    }
}