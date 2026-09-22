#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RotateVaultCredentialAuthParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RotateVaultCredentialAuthParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RotateVaultCredentialAuthParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth? mcpOauth = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType.McpOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth)}");
                mcpOauth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer? staticBearer = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType.StaticBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer)}");
                staticBearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable? environmentVariable = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RotateVaultCredentialAuthParamDiscriminatorType.EnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable)}");
                environmentVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.RotateVaultCredentialAuthParam(
                discriminator?.Type,
                mcpOauth,

                staticBearer,

                environmentVariable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RotateVaultCredentialAuthParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcpOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamMcpOauth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpOauth!, typeInfo);
            }
            else if (value.IsStaticBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamStaticBearer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StaticBearer!, typeInfo);
            }
            else if (value.IsEnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RotateVaultCredentialAuthParamEnvironmentVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentVariable!, typeInfo);
            }
        }
    }
}