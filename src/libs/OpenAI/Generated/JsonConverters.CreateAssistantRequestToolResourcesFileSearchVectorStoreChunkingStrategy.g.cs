#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value1 = default;
            if (discriminator?.Type == global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value2 = default;
            if (discriminator?.Type == global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
                discriminator?.Type,
                value1,
                value2
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}