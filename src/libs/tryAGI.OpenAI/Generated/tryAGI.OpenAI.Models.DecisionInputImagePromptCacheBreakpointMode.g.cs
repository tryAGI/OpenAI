
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The breakpoint mode. Always `explicit`.<br/>
    /// Default Value: explicit
    /// </summary>
    public enum DecisionInputImagePromptCacheBreakpointMode
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputImagePromptCacheBreakpointModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputImagePromptCacheBreakpointMode value)
        {
            return value switch
            {
                DecisionInputImagePromptCacheBreakpointMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputImagePromptCacheBreakpointMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => DecisionInputImagePromptCacheBreakpointMode.Explicit,
                _ => null,
            };
        }
    }
}