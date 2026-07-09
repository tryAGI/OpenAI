
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Background type for the generated image. One of `transparent`,<br/>
    /// `opaque`, or `auto`. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BetaImageGenToolBackground
    {
        /// <summary>
        /// `auto`.
        /// </summary>
        Auto,
        /// <summary>
        /// `auto`.
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
    public static class BetaImageGenToolBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolBackground value)
        {
            return value switch
            {
                BetaImageGenToolBackground.Auto => "auto",
                BetaImageGenToolBackground.Opaque => "opaque",
                BetaImageGenToolBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageGenToolBackground.Auto,
                "opaque" => BetaImageGenToolBackground.Opaque,
                "transparent" => BetaImageGenToolBackground.Transparent,
                _ => null,
            };
        }
    }
}