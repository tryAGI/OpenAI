
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The breakpoint mode. Always `explicit`.<br/>
    /// Default Value: explicit
    /// </summary>
    public enum BetaPromptCacheBreakpointParamMode
    {
        /// <summary>
        /// 
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheBreakpointParamModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheBreakpointParamMode value)
        {
            return value switch
            {
                BetaPromptCacheBreakpointParamMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheBreakpointParamMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => BetaPromptCacheBreakpointParamMode.Explicit,
                _ => null,
            };
        }
    }
}