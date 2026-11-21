
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResolvedImageContextCompressionEnum
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResolvedImageContextCompressionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResolvedImageContextCompressionEnum value)
        {
            return value switch
            {
                BetaResolvedImageContextCompressionEnum.Disabled => "disabled",
                BetaResolvedImageContextCompressionEnum.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResolvedImageContextCompressionEnum? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaResolvedImageContextCompressionEnum.Disabled,
                "enabled" => BetaResolvedImageContextCompressionEnum.Enabled,
                _ => null,
            };
        }
    }
}