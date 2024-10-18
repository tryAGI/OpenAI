#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value1 = default;
            if (discriminator?.Type == global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value2 = default;
            if (discriminator?.Type == global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
                discriminator?.Type,
                value1,
                value2
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}