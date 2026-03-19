#nullable enable

namespace tryAGI.OpenAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationItemInputAudioTranscriptionFailedPayloadTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadType?>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadType? Read(
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
                        return global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayloadTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
