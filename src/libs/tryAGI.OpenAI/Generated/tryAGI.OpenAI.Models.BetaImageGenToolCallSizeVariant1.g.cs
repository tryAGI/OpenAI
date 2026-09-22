
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaImageGenToolCallSizeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        x1024x1024,
        /// <summary>
        ///
        /// </summary>
        x1024x1536,
        /// <summary>
        ///
        /// </summary>
        x1536x1024,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolCallSizeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolCallSizeVariant1 value)
        {
            return value switch
            {
                BetaImageGenToolCallSizeVariant1.x1024x1024 => "1024x1024",
                BetaImageGenToolCallSizeVariant1.x1024x1536 => "1024x1536",
                BetaImageGenToolCallSizeVariant1.x1536x1024 => "1536x1024",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolCallSizeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => BetaImageGenToolCallSizeVariant1.x1024x1024,
                "1024x1536" => BetaImageGenToolCallSizeVariant1.x1024x1536,
                "1536x1024" => BetaImageGenToolCallSizeVariant1.x1536x1024,
                _ => null,
            };
        }
    }
}