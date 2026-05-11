
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServiceTierEnum2
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
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTierEnum2 value)
        {
            return value switch
            {
                ServiceTierEnum2.Auto => "auto",
                ServiceTierEnum2.Default => "default",
                ServiceTierEnum2.Flex => "flex",
                ServiceTierEnum2.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTierEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTierEnum2.Auto,
                "default" => ServiceTierEnum2.Default,
                "flex" => ServiceTierEnum2.Flex,
                "priority" => ServiceTierEnum2.Priority,
                _ => null,
            };
        }
    }
}