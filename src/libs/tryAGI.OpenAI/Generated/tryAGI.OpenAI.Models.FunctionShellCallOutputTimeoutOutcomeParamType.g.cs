
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The outcome type. Always `timeout`.<br/>
    /// Default Value: timeout
    /// </summary>
    public enum FunctionShellCallOutputTimeoutOutcomeParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionShellCallOutputTimeoutOutcomeParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionShellCallOutputTimeoutOutcomeParamType value)
        {
            return value switch
            {
                FunctionShellCallOutputTimeoutOutcomeParamType.Timeout => "timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionShellCallOutputTimeoutOutcomeParamType? ToEnum(string value)
        {
            return value switch
            {
                "timeout" => FunctionShellCallOutputTimeoutOutcomeParamType.Timeout,
                _ => null,
            };
        }
    }
}