
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The caller type. Always `direct`.<br/>
    /// Default Value: direct
    /// </summary>
    public enum BetaDirectToolCallCallerParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDirectToolCallCallerParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDirectToolCallCallerParamType value)
        {
            return value switch
            {
                BetaDirectToolCallCallerParamType.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDirectToolCallCallerParamType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaDirectToolCallCallerParamType.Direct,
                _ => null,
            };
        }
    }
}