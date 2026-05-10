
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType value)
        {
            return value switch
            {
                CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType.JsonObject => "json_object",
                CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType.JsonSchema => "json_schema",
                CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType.JsonObject,
                "json_schema" => CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType.JsonSchema,
                "text" => CreateChatCompletionRequestVariant2ResponseFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}