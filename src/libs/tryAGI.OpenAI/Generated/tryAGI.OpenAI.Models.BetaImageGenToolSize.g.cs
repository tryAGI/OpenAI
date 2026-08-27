
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaImageGenToolSize
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
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolSize value)
        {
            return value switch
            {
                BetaImageGenToolSize.x1024x1024 => "1024x1024",
                BetaImageGenToolSize.x1024x1536 => "1024x1536",
                BetaImageGenToolSize.x1536x1024 => "1536x1024",
                BetaImageGenToolSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => BetaImageGenToolSize.x1024x1024,
                "1024x1536" => BetaImageGenToolSize.x1024x1536,
                "1536x1024" => BetaImageGenToolSize.x1536x1024,
                "auto" => BetaImageGenToolSize.Auto,
                _ => null,
            };
        }
    }
}