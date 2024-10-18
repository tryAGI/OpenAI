#nullable enable

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChunkingStrategyRequestParamDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ChunkingStrategyRequestParamDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::OpenAI.ChunkingStrategyRequestParamDiscriminatorType Read(
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
                        return global::OpenAI.ChunkingStrategyRequestParamDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.ChunkingStrategyRequestParamDiscriminatorType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ChunkingStrategyRequestParamDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.ChunkingStrategyRequestParamDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
