#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateVectorStoreRequestChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.CreateVectorStoreRequestChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::OpenAI.CreateVectorStoreRequestChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.AutoChunkingStrategyRequestParam? autoParam = default;
            if (discriminator?.Type == global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminatorType.Auto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AutoChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AutoChunkingStrategyRequestParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AutoChunkingStrategyRequestParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.StaticChunkingStrategyRequestParam? staticParam = default;
            if (discriminator?.Type == global::OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyRequestParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.StaticChunkingStrategyRequestParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.CreateVectorStoreRequestChunkingStrategy(
                discriminator?.Type,
                autoParam,
                staticParam
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.CreateVectorStoreRequestChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoParam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AutoChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AutoChunkingStrategyRequestParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AutoChunkingStrategyRequestParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoParam, typeInfo);
            }
            else if (value.IsStaticParam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyRequestParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.StaticChunkingStrategyRequestParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StaticParam, typeInfo);
            }
        }
    }
}