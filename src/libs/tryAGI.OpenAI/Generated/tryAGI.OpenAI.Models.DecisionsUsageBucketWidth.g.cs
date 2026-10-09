
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsUsageBucketWidth
    {
        /// <summary>
        ///
        /// </summary>
        x1d,
        /// <summary>
        ///
        /// </summary>
        x1h,
        /// <summary>
        ///
        /// </summary>
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsUsageBucketWidthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsUsageBucketWidth value)
        {
            return value switch
            {
                DecisionsUsageBucketWidth.x1d => "1d",
                DecisionsUsageBucketWidth.x1h => "1h",
                DecisionsUsageBucketWidth.x1m => "1m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsUsageBucketWidth? ToEnum(string value)
        {
            return value switch
            {
                "1d" => DecisionsUsageBucketWidth.x1d,
                "1h" => DecisionsUsageBucketWidth.x1h,
                "1m" => DecisionsUsageBucketWidth.x1m,
                _ => null,
            };
        }
    }
}