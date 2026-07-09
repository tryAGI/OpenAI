
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The caller type. Always `direct`.<br/>
    /// Default Value: direct
    /// </summary>
    public enum DirectToolCallCallerParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectToolCallCallerParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectToolCallCallerParamType value)
        {
            return value switch
            {
                DirectToolCallCallerParamType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectToolCallCallerParamType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => DirectToolCallCallerParamType.Direct,
                _ => null,
            };
        }
    }
}