
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectDefaultServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Scale,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectDefaultServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDefaultServiceTier value)
        {
            return value switch
            {
                ProjectDefaultServiceTier.Fast => "fast",
                ProjectDefaultServiceTier.Scale => "scale",
                ProjectDefaultServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDefaultServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "fast" => ProjectDefaultServiceTier.Fast,
                "scale" => ProjectDefaultServiceTier.Scale,
                "standard" => ProjectDefaultServiceTier.Standard,
                _ => null,
            };
        }
    }
}