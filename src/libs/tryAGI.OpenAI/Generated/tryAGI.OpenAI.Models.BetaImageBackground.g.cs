
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaImageBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageBackground value)
        {
            return value switch
            {
                BetaImageBackground.Auto => "auto",
                BetaImageBackground.Opaque => "opaque",
                BetaImageBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageBackground.Auto,
                "opaque" => BetaImageBackground.Opaque,
                "transparent" => BetaImageBackground.Transparent,
                _ => null,
            };
        }
    }
}