
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The service tier used for processing the request. This field is only included if the `service_tier` parameter is specified in the request.<br/>
    /// Example: scale
    /// </summary>
    public enum CreateChatCompletionStreamResponseServiceTier
    {
        /// <summary>
        /// 
        /// </summary>
        Scale,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionStreamResponseServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionStreamResponseServiceTier value)
        {
            return value switch
            {
                CreateChatCompletionStreamResponseServiceTier.Scale => "scale",
                CreateChatCompletionStreamResponseServiceTier.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionStreamResponseServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "scale" => CreateChatCompletionStreamResponseServiceTier.Scale,
                "default" => CreateChatCompletionStreamResponseServiceTier.Default,
                _ => null,
            };
        }
    }
}