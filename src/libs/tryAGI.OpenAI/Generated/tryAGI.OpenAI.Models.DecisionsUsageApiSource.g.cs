
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionsUsageApiSource
    {
        /// <summary>
        ///
        /// </summary>
        AgentsApi,
        /// <summary>
        ///
        /// </summary>
        Unlabeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionsUsageApiSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionsUsageApiSource value)
        {
            return value switch
            {
                DecisionsUsageApiSource.AgentsApi => "agents_api",
                DecisionsUsageApiSource.Unlabeled => "unlabeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionsUsageApiSource? ToEnum(string value)
        {
            return value switch
            {
                "agents_api" => DecisionsUsageApiSource.AgentsApi,
                "unlabeled" => DecisionsUsageApiSource.Unlabeled,
                _ => null,
            };
        }
    }
}