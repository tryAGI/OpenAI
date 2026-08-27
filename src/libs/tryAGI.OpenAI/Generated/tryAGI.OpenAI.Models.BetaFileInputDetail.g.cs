
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFileInputDetail
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileInputDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileInputDetail value)
        {
            return value switch
            {
                BetaFileInputDetail.Auto => "auto",
                BetaFileInputDetail.High => "high",
                BetaFileInputDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileInputDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaFileInputDetail.Auto,
                "high" => BetaFileInputDetail.High,
                "low" => BetaFileInputDetail.Low,
                _ => null,
            };
        }
    }
}