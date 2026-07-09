
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaSearchContextSize
    {
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
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSearchContextSize value)
        {
            return value switch
            {
                BetaSearchContextSize.High => "high",
                BetaSearchContextSize.Low => "low",
                BetaSearchContextSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaSearchContextSize.High,
                "low" => BetaSearchContextSize.Low,
                "medium" => BetaSearchContextSize.Medium,
                _ => null,
            };
        }
    }
}