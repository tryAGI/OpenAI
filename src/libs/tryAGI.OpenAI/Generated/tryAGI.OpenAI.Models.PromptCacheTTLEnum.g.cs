
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCacheTTLEnum
    {
        /// <summary>
        /// 
        /// </summary>
        x30m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptCacheTTLEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheTTLEnum value)
        {
            return value switch
            {
                PromptCacheTTLEnum.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheTTLEnum? ToEnum(string value)
        {
            return value switch
            {
                "30m" => PromptCacheTTLEnum.x30m,
                _ => null,
            };
        }
    }
}