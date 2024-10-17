#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeClientEventSessionUpdateSessionMaxOutputTokensJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RealtimeClientEventSessionUpdateSessionMaxOutputTokens>
    {
        /// <inheritdoc />
        public override global::OpenAI.RealtimeClientEventSessionUpdateSessionMaxOutputTokens Read(
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
                        return global::OpenAI.RealtimeClientEventSessionUpdateSessionMaxOutputTokensExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.RealtimeClientEventSessionUpdateSessionMaxOutputTokens)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RealtimeClientEventSessionUpdateSessionMaxOutputTokens value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.RealtimeClientEventSessionUpdateSessionMaxOutputTokensExtensions.ToValueString(value));
        }
    }
}
