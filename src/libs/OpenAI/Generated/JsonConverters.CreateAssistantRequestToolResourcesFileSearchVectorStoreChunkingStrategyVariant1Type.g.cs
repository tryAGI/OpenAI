#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type Read(
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
                        return global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeExtensions.ToValueString(value));
        }
    }
}
