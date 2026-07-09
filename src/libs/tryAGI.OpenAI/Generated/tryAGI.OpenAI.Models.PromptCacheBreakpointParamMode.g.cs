
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The breakpoint mode. Always `explicit`.<br/>
    /// Default Value: explicit
    /// </summary>
    public enum PromptCacheBreakpointParamMode
    {
        /// <summary>
        /// 
        /// </summary>
        Explicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheBreakpointParamModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheBreakpointParamMode value)
        {
            return value switch
            {
                PromptCacheBreakpointParamMode.Explicit => "explicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheBreakpointParamMode? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => PromptCacheBreakpointParamMode.Explicit,
                _ => null,
            };
        }
    }
}