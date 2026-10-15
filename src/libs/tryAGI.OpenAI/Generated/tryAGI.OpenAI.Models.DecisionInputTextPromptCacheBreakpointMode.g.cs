
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The breakpoint mode. Always `explicit`.<br/>
    /// Default Value: explicit
    /// </summary>
    public enum DecisionInputTextPromptCacheBreakpointMode
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputTextPromptCacheBreakpointModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputTextPromptCacheBreakpointMode value)
        {
            return value switch
            {
                DecisionInputTextPromptCacheBreakpointMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputTextPromptCacheBreakpointMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => DecisionInputTextPromptCacheBreakpointMode.Explicit,
                _ => null,
            };
        }
    }
}