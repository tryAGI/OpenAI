
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The minimum lifetime applied to every implicit and explicit cache breakpoint written by the request. Defaults to `30m`, which is currently the only supported value. The backend may retain cache entries for longer.<br/>
    /// Default Value: 30m
    /// </summary>
    public enum DecisionRequestPromptCacheOptionsTtl
    {
        /// <summary>
        ///
        /// </summary>
        x30m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionRequestPromptCacheOptionsTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionRequestPromptCacheOptionsTtl value)
        {
            return value switch
            {
                DecisionRequestPromptCacheOptionsTtl.x30m => "30m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionRequestPromptCacheOptionsTtl? ToEnum(string value)
        {
            return value switch
            {
                "30m" => DecisionRequestPromptCacheOptionsTtl.x30m,
                _ => null,
            };
        }
    }
}