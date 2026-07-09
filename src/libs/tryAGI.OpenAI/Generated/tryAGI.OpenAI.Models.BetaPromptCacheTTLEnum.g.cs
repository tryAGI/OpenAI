
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPromptCacheTTLEnum
    {
        /// <summary>
        /// 
        /// </summary>
        x30m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheTTLEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheTTLEnum value)
        {
            return value switch
            {
                BetaPromptCacheTTLEnum.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheTTLEnum? ToEnum(string value)
        {
            return value switch
            {
                "30m" => BetaPromptCacheTTLEnum.x30m,
                _ => null,
            };
        }
    }
}