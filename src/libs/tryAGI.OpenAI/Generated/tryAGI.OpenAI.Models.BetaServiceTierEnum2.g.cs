
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
    public enum BetaServiceTierEnum2
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
        /// //openai.com/api-priority-processing/)', then the request will be processed with the corresponding service tier.
        /// </summary>
        Priority,
        /// <summary>
        /// 
        /// </summary>
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaServiceTierEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceTierEnum2 value)
        {
            return value switch
            {
                BetaServiceTierEnum2.Auto => "auto",
                BetaServiceTierEnum2.Default => "default",
                BetaServiceTierEnum2.Flex => "flex",
                BetaServiceTierEnum2.Priority => "priority",
                BetaServiceTierEnum2.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceTierEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaServiceTierEnum2.Auto,
                "default" => BetaServiceTierEnum2.Default,
                "flex" => BetaServiceTierEnum2.Flex,
                "priority" => BetaServiceTierEnum2.Priority,
                "scale" => BetaServiceTierEnum2.Scale,
                _ => null,
            };
        }
    }
}