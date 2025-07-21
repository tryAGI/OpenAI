
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the processing type used for serving the request.<br/>
    ///   - If set to 'auto', then the request will be processed with the service tier configured in the Project settings. Unless otherwise configured, the Project will use 'default'.<br/>
    ///   - If set to 'default', then the request will be processed with the standard pricing and performance for the selected model.<br/>
    ///   - If set to '[flex](/docs/guides/flex-processing)' or 'priority', then the request will be processed with the corresponding service tier. [Contact sales](https://openai.com/contact-sales) to learn more about Priority processing.<br/>
    ///   - When not set, the default behavior is 'auto'.<br/>
    ///   When the `service_tier` parameter is set, the response body will include the `service_tier` value based on the processing mode actually used to serve the request. This response value may be different from the value set in the parameter.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ServiceTier
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
        /// //openai.com/contact-sales) to learn more about Priority processing.
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// //openai.com/contact-sales) to learn more about Priority processing.
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceTier value)
        {
            return value switch
            {
                ServiceTier.Auto => "auto",
                ServiceTier.Default => "default",
                ServiceTier.Flex => "flex",
                ServiceTier.Scale => "scale",
                ServiceTier.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ServiceTier.Auto,
                "default" => ServiceTier.Default,
                "flex" => ServiceTier.Flex,
                "scale" => ServiceTier.Scale,
                "priority" => ServiceTier.Priority,
                _ => null,
            };
        }
    }
}