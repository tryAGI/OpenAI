#nullable enable

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneDPOMethodHyperparametersBetaNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBeta?>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBeta? Read(
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
                        return global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBetaExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBeta)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBeta?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBeta? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::tryAGI.OpenAI.FineTuneDPOMethodHyperparametersBetaExtensions.ToValueString(value.Value));
            }
        }
    }
}
