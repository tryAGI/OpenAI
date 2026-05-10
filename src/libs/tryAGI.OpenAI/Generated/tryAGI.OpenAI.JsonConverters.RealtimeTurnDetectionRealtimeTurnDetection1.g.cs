#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeTurnDetectionRealtimeTurnDetection1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad? serverVad = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType.ServerVad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad)}");
                serverVad = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad? semanticVad = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1DiscriminatorType.SemanticVad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad)}");
                semanticVad = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1(
                discriminator?.Type,
                serverVad,

                semanticVad
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsServerVad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1ServerVad).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerVad!, typeInfo);
            }
            else if (value.IsSemanticVad)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTurnDetectionRealtimeTurnDetection1SemanticVad).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SemanticVad!, typeInfo);
            }
        }
    }
}