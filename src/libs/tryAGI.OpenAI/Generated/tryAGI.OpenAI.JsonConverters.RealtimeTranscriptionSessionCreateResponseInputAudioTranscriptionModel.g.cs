#nullable enable

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModelJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel Read(
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
                        return global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModelExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModelExtensions.ToValueString(value));
        }
    }
}
