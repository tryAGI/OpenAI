
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The breakpoint mode. Always `explicit`.<br/>
    /// Default Value: explicit
    /// </summary>
    public enum PromptCacheBreakpointConfigMode
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheBreakpointConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheBreakpointConfigMode value)
        {
            return value switch
            {
                PromptCacheBreakpointConfigMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheBreakpointConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => PromptCacheBreakpointConfigMode.Explicit,
                _ => null,
            };
        }
    }
}