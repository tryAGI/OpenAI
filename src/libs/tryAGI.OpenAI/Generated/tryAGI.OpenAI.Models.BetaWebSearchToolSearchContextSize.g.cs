
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// High level guidance for the amount of context window space to use for the search. One of `low`, `medium`, or `high`. `medium` is the default.<br/>
    /// Default Value: medium
    /// </summary>
    public enum BetaWebSearchToolSearchContextSize
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
    public static class BetaWebSearchToolSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchToolSearchContextSize value)
        {
            return value switch
            {
                BetaWebSearchToolSearchContextSize.High => "high",
                BetaWebSearchToolSearchContextSize.Low => "low",
                BetaWebSearchToolSearchContextSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchToolSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaWebSearchToolSearchContextSize.High,
                "low" => BetaWebSearchToolSearchContextSize.Low,
                "medium" => BetaWebSearchToolSearchContextSize.Medium,
                _ => null,
            };
        }
    }
}