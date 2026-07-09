
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPromptCacheModeEnum
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
    public static class BetaPromptCacheModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheModeEnum value)
        {
            return value switch
            {
                BetaPromptCacheModeEnum.Explicit => "explicit",
                BetaPromptCacheModeEnum.Implicit => "implicit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => BetaPromptCacheModeEnum.Explicit,
                "implicit" => BetaPromptCacheModeEnum.Implicit,
                _ => null,
            };
        }
    }
}