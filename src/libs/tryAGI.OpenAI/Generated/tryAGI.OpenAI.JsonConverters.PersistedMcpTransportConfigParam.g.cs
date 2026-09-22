#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class PersistedMcpTransportConfigParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.PersistedMcpTransportConfigParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.PersistedMcpTransportConfigParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp? http = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType.Http)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp)}");
                http = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio? stdio = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.PersistedMcpTransportConfigParamDiscriminatorType.Stdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio)}");
                stdio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.PersistedMcpTransportConfigParam(
                discriminator?.Type,
                http,

                stdio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.PersistedMcpTransportConfigParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHttp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamHttp).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Http!, typeInfo);
            }
            else if (value.IsStdio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.PersistedMcpTransportConfigParamStdio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stdio!, typeInfo);
            }
        }
    }
}