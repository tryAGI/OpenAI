
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaImageDetail
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
    public static class BetaImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageDetail value)
        {
            return value switch
            {
                BetaImageDetail.Auto => "auto",
                BetaImageDetail.High => "high",
                BetaImageDetail.Low => "low",
                BetaImageDetail.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageDetail.Auto,
                "high" => BetaImageDetail.High,
                "low" => BetaImageDetail.Low,
                "original" => BetaImageDetail.Original,
                _ => null,
            };
        }
    }
}