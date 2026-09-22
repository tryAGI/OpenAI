
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The service tier used for model requests.
    /// </summary>
    public enum ServiceTierParam
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
    public static class ServiceTierParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTierParam value)
        {
            return value switch
            {
                ServiceTierParam.Auto => "auto",
                ServiceTierParam.Default => "default",
                ServiceTierParam.Fast => "fast",
                ServiceTierParam.Flex => "flex",
                ServiceTierParam.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTierParam? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTierParam.Auto,
                "default" => ServiceTierParam.Default,
                "fast" => ServiceTierParam.Fast,
                "flex" => ServiceTierParam.Flex,
                "priority" => ServiceTierParam.Priority,
                _ => null,
            };
        }
    }
}