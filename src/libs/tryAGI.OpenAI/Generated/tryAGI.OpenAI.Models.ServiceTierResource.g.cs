
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The service-tier policy configured for an agent.
    /// </summary>
    public enum ServiceTierResource
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Flex,
        /// <summary>
        ///
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTierResource value)
        {
            return value switch
            {
                ServiceTierResource.Auto => "auto",
                ServiceTierResource.Default => "default",
                ServiceTierResource.Fast => "fast",
                ServiceTierResource.Flex => "flex",
                ServiceTierResource.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTierResource? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTierResource.Auto,
                "default" => ServiceTierResource.Default,
                "fast" => ServiceTierResource.Fast,
                "flex" => ServiceTierResource.Flex,
                "priority" => ServiceTierResource.Priority,
                _ => null,
            };
        }
    }
}