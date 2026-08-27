
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRankerVersionType
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Default20241115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRankerVersionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRankerVersionType value)
        {
            return value switch
            {
                BetaRankerVersionType.Auto => "auto",
                BetaRankerVersionType.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRankerVersionType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaRankerVersionType.Auto,
                "default-2024-11-15" => BetaRankerVersionType.Default20241115,
                _ => null,
            };
        }
    }
}