
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Moderation level for the generated image. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BetaImageGenToolModeration
    {
        /// <summary>
        /// `auto`.
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolModerationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolModeration value)
        {
            return value switch
            {
                BetaImageGenToolModeration.Auto => "auto",
                BetaImageGenToolModeration.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolModeration? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageGenToolModeration.Auto,
                "low" => BetaImageGenToolModeration.Low,
                _ => null,
            };
        }
    }
}