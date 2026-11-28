
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ProjectOptionalServiceTier
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        Ultrafast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectOptionalServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectOptionalServiceTier value)
        {
            return value switch
            {
                ProjectOptionalServiceTier.Fast => "fast",
                ProjectOptionalServiceTier.Flex => "flex",
                ProjectOptionalServiceTier.Ultrafast => "ultrafast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectOptionalServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "fast" => ProjectOptionalServiceTier.Fast,
                "flex" => ProjectOptionalServiceTier.Flex,
                "ultrafast" => ProjectOptionalServiceTier.Ultrafast,
                _ => null,
            };
        }
    }
}