
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResolvedImageContextCompressionEnum
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
    public static class ResolvedImageContextCompressionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolvedImageContextCompressionEnum value)
        {
            return value switch
            {
                ResolvedImageContextCompressionEnum.Disabled => "disabled",
                ResolvedImageContextCompressionEnum.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolvedImageContextCompressionEnum? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => ResolvedImageContextCompressionEnum.Disabled,
                "enabled" => ResolvedImageContextCompressionEnum.Enabled,
                _ => null,
            };
        }
    }
}