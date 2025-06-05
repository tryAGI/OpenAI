#nullable enable

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectApiKeyListResponseObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ProjectApiKeyListResponseObject?>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ProjectApiKeyListResponseObject? Read(
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
                        return global::tryAGI.OpenAI.ProjectApiKeyListResponseObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.ProjectApiKeyListResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.ProjectApiKeyListResponseObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ProjectApiKeyListResponseObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.OpenAI.ProjectApiKeyListResponseObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
