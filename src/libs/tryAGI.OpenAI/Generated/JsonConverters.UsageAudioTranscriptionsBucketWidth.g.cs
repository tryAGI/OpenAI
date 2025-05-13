#nullable enable

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class UsageAudioTranscriptionsBucketWidthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth Read(
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
                        return global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidthExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.OpenAI.UsageAudioTranscriptionsBucketWidthExtensions.ToValueString(value));
        }
    }
}
