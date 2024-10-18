#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class VectorStoreFileObjectChunkingStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.VectorStoreFileObjectChunkingStrategy>
    {
        /// <inheritdoc />
        public override global::OpenAI.VectorStoreFileObjectChunkingStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.StaticChunkingStrategyResponseParam? staticResponseParam = default;
            if (discriminator?.Type == global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminatorType.Static)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyResponseParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.StaticChunkingStrategyResponseParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.OtherChunkingStrategyResponseParam? otherResponseParam = default;
            if (discriminator?.Type == global::OpenAI.VectorStoreFileObjectChunkingStrategyDiscriminatorType.Other)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.OtherChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.OtherChunkingStrategyResponseParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.OtherChunkingStrategyResponseParam)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.VectorStoreFileObjectChunkingStrategy(
                discriminator?.Type,
                staticResponseParam,
                otherResponseParam
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.VectorStoreFileObjectChunkingStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStaticResponseParam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyResponseParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.StaticChunkingStrategyResponseParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StaticResponseParam, typeInfo);
            }
            else if (value.IsOtherResponseParam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.OtherChunkingStrategyResponseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.OtherChunkingStrategyResponseParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.OtherChunkingStrategyResponseParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OtherResponseParam, typeInfo);
            }
        }
    }
}