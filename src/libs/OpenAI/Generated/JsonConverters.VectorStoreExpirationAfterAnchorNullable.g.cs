#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class VectorStoreExpirationAfterAnchorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.VectorStoreExpirationAfterAnchor?>
    {
        /// <inheritdoc />
        public override global::OpenAI.VectorStoreExpirationAfterAnchor? Read(
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
                        return global::OpenAI.VectorStoreExpirationAfterAnchorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.VectorStoreExpirationAfterAnchor)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.VectorStoreExpirationAfterAnchor? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenAI.VectorStoreExpirationAfterAnchorExtensions.ToValueString(value.Value));
            }
        }
    }
}
