#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionFunctionResponseChoicesFinishReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateChatCompletionFunctionResponseChoicesFinishReason?>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateChatCompletionFunctionResponseChoicesFinishReason? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::OpenAI.CreateChatCompletionFunctionResponseChoicesFinishReasonExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.CreateChatCompletionFunctionResponseChoicesFinishReason)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateChatCompletionFunctionResponseChoicesFinishReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenAI.CreateChatCompletionFunctionResponseChoicesFinishReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
