#nullable enable

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneSupervisedMethodHyperparametersBatchSizeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize Read(
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
                        return global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSizeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSize value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::tryAGI.OpenAI.FineTuneSupervisedMethodHyperparametersBatchSizeExtensions.ToValueString(value));
        }
    }
}
