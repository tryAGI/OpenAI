
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum UsageWebSearchCallsResultApiSource
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
    public static class UsageWebSearchCallsResultApiSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageWebSearchCallsResultApiSource value)
        {
            return value switch
            {
                UsageWebSearchCallsResultApiSource.AgentsApi => "agents_api",
                UsageWebSearchCallsResultApiSource.Unlabeled => "unlabeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageWebSearchCallsResultApiSource? ToEnum(string value)
        {
            return value switch
            {
                "agents_api" => UsageWebSearchCallsResultApiSource.AgentsApi,
                "unlabeled" => UsageWebSearchCallsResultApiSource.Unlabeled,
                _ => null,
            };
        }
    }
}