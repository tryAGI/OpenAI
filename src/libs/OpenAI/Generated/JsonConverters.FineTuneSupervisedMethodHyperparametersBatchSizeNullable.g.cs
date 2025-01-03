#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneSupervisedMethodHyperparametersBatchSizeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize?>
    {
        /// <inheritdoc />
        public override global::OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize? Read(
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
                        return global::OpenAI.FineTuneSupervisedMethodHyperparametersBatchSizeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenAI.FineTuneSupervisedMethodHyperparametersBatchSizeExtensions.ToValueString(value.Value));
            }
        }
    }
}
