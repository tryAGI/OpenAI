
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Specifies the processing type used for serving the request.<br/>
    ///   - If set to 'auto', then the request will be processed with the service tier configured in the Project settings. Unless otherwise configured, the Project will use 'default'.<br/>
    ///   - If set to 'default', then the request will be processed with the standard pricing and performance for the selected model.<br/>
    ///   - If set to '[flex](https://developers.openai.com/api/docs/guides/flex-processing)', then the request will be processed with the Flex Processing service tier.<br/>
    ///   - To opt-in to [Fast mode](https://developers.openai.com/api/docs/guides/fast-mode) at the request level, include the `service_tier=fast` or `service_tier=priority` parameter for Responses or Chat Completions. The response will show `service_tier=priority` regardless of if you specify `service_tier=fast` or `priority` in your request.<br/>
    ///   - If set to 'ultrafast', then the request will be processed with the access-controlled Ultrafast Processing service tier. This tier is currently available for `gpt-5.6-sol`; a response served through it will show `service_tier=ultrafast`.<br/>
    ///   - When not set, the default behavior is 'auto'.<br/>
    ///   When the `service_tier` parameter is set, the response body will include the `service_tier` value based on the processing mode actually used to serve the request. This response value may be different from the value set in the parameter.<br/>
    /// Default Value: auto
    /// </summary>
    public enum BetaServiceTierResponsesEnum
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
        /// //developers.openai.com/api/docs/guides/fast-mode) at the request level, include the `service_tier=fast` or `service_tier=priority` parameter for Responses or Chat Completions. The response will show `service_tier=priority` regardless of if you specify `service_tier=fast` or `priority` in your request.
        /// </summary>
        Fast,
        /// <summary>
        /// //developers.openai.com/api/docs/guides/flex-processing)', then the request will be processed with the Flex Processing service tier.
        /// </summary>
        Flex,
        /// <summary>
        /// //developers.openai.com/api/docs/guides/fast-mode) at the request level, include the `service_tier=fast` or `service_tier=priority` parameter for Responses or Chat Completions. The response will show `service_tier=priority` regardless of if you specify `service_tier=fast` or `priority` in your request.
        /// </summary>
        Priority,
        /// <summary>
        ///
        /// </summary>
        Scale,
        /// <summary>
        ///
        /// </summary>
        Ultrafast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaServiceTierResponsesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceTierResponsesEnum value)
        {
            return value switch
            {
                BetaServiceTierResponsesEnum.Auto => "auto",
                BetaServiceTierResponsesEnum.Default => "default",
                BetaServiceTierResponsesEnum.Fast => "fast",
                BetaServiceTierResponsesEnum.Flex => "flex",
                BetaServiceTierResponsesEnum.Priority => "priority",
                BetaServiceTierResponsesEnum.Scale => "scale",
                BetaServiceTierResponsesEnum.Ultrafast => "ultrafast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceTierResponsesEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaServiceTierResponsesEnum.Auto,
                "default" => BetaServiceTierResponsesEnum.Default,
                "fast" => BetaServiceTierResponsesEnum.Fast,
                "flex" => BetaServiceTierResponsesEnum.Flex,
                "priority" => BetaServiceTierResponsesEnum.Priority,
                "scale" => BetaServiceTierResponsesEnum.Scale,
                "ultrafast" => BetaServiceTierResponsesEnum.Ultrafast,
                _ => null,
            };
        }
    }
}