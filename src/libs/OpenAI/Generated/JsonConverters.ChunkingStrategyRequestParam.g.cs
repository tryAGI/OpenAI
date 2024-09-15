#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ChunkingStrategyRequestParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ChunkingStrategyRequestParam>
    {
        /// <inheritdoc />
        public override global::OpenAI.ChunkingStrategyRequestParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::OpenAI.AutoChunkingStrategyRequestParam? auto = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AutoChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AutoChunkingStrategyRequestParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AutoChunkingStrategyRequestParam).Name}");
                auto = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.StaticChunkingStrategyRequestParam? @static = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyRequestParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.StaticChunkingStrategyRequestParam).Name}");
                @static = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::OpenAI.ChunkingStrategyRequestParam(
                auto,
                @static
                );

            if (auto != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AutoChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AutoChunkingStrategyRequestParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AutoChunkingStrategyRequestParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (@static != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyRequestParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.StaticChunkingStrategyRequestParam).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ChunkingStrategyRequestParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AutoChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AutoChunkingStrategyRequestParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AutoChunkingStrategyRequestParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Auto, typeInfo);
            }
            else if (value.IsStatic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.StaticChunkingStrategyRequestParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.StaticChunkingStrategyRequestParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.StaticChunkingStrategyRequestParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Static, typeInfo);
            }
        }
    }
}