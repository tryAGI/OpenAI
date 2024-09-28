#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem?>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? Read(
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
                        return global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenAI.CreateModerationResponseResultCategoryAppliedInputTypesSelfHarmItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
