
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UsageCompletionsResultApiSource
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
    public static class UsageCompletionsResultApiSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageCompletionsResultApiSource value)
        {
            return value switch
            {
                UsageCompletionsResultApiSource.AgentsApi => "agents_api",
                UsageCompletionsResultApiSource.Unlabeled => "unlabeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageCompletionsResultApiSource? ToEnum(string value)
        {
            return value switch
            {
                "agents_api" => UsageCompletionsResultApiSource.AgentsApi,
                "unlabeled" => UsageCompletionsResultApiSource.Unlabeled,
                _ => null,
            };
        }
    }
}