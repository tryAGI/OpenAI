
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaDetailEnum
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaDetailEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaDetailEnum value)
        {
            return value switch
            {
                BetaDetailEnum.Auto => "auto",
                BetaDetailEnum.High => "high",
                BetaDetailEnum.Low => "low",
                BetaDetailEnum.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaDetailEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaDetailEnum.Auto,
                "high" => BetaDetailEnum.High,
                "low" => BetaDetailEnum.Low,
                "original" => BetaDetailEnum.Original,
                _ => null,
            };
        }
    }
}