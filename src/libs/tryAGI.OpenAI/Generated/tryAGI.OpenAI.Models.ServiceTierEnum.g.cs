
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the processing type used for serving the request.<br/>
    ///   - If set to 'auto', then the request will be processed with the service tier configured in the Project settings. Unless otherwise configured, the Project will use 'default'.<br/>
    ///   - If set to 'default', then the request will be processed with the standard pricing and performance for the selected model.<br/>
    ///   - If set to '[flex](/docs/guides/flex-processing)' or '[priority](https://openai.com/api-priority-processing/)', then the request will be processed with the corresponding service tier.<br/>
    ///   - When not set, the default behavior is 'auto'.<br/>
    ///   When the `service_tier` parameter is set, the response body will include the `service_tier` value based on the processing mode actually used to serve the request. This response value may be different from the value set in the parameter.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ServiceTierEnum
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
        /// //openai.com/api-priority-processing/)', then the request will be processed with the corresponding service tier.
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// //openai.com/api-priority-processing/)', then the request will be processed with the corresponding service tier.
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTierEnum value)
        {
            return value switch
            {
                ServiceTierEnum.Auto => "auto",
                ServiceTierEnum.Default => "default",
                ServiceTierEnum.Flex => "flex",
                ServiceTierEnum.Scale => "scale",
                ServiceTierEnum.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTierEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTierEnum.Auto,
                "default" => ServiceTierEnum.Default,
                "flex" => ServiceTierEnum.Flex,
                "scale" => ServiceTierEnum.Scale,
                "priority" => ServiceTierEnum.Priority,
                _ => null,
            };
        }
    }
}