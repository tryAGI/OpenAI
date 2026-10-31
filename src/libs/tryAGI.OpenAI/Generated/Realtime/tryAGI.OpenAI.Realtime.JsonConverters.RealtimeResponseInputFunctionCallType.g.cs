#nullable enable

namespace tryAGI.OpenAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class RealtimeResponseInputFunctionCallTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType Read(
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
                        return global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallTypeExtensions.ToEnum(stringValue) ?? throw new global::System.Text.Json.JsonException($"Unknown discriminator value '{stringValue}' for global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType.");
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallTypeExtensions.ToValueString(value));
        }
    }
}
