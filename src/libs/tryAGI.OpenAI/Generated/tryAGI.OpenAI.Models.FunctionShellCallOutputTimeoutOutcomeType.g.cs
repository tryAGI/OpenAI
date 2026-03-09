
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `timeout`.<br/>
    /// Default Value: timeout
    /// </summary>
    public enum FunctionShellCallOutputTimeoutOutcomeType
    {
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputTimeoutOutcomeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputTimeoutOutcomeType value)
        {
            return value switch
            {
                FunctionShellCallOutputTimeoutOutcomeType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputTimeoutOutcomeType? ToEnum(string value)
        {
            return value switch
            {
                "timeout" => FunctionShellCallOutputTimeoutOutcomeType.Timeout,
                _ => null,
            };
        }
    }
}