
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PromptCacheModeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        Implicit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheModeEnum value)
        {
            return value switch
            {
                PromptCacheModeEnum.Explicit => "explicit",
                PromptCacheModeEnum.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => PromptCacheModeEnum.Explicit,
                "implicit" => PromptCacheModeEnum.Implicit,
                _ => null,
            };
        }
    }
}