
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The breakpoint mode. Always `explicit`.<br/>
    /// Default Value: explicit
    /// </summary>
    public enum BetaPromptCacheBreakpointConfigMode
    {
        /// <summary>
        /// 
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheBreakpointConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheBreakpointConfigMode value)
        {
            return value switch
            {
                BetaPromptCacheBreakpointConfigMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheBreakpointConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => BetaPromptCacheBreakpointConfigMode.Explicit,
                _ => null,
            };
        }
    }
}