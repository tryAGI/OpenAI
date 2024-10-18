#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageDeltaObjectDeltaContentItemDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType Read(
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
                        return global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
