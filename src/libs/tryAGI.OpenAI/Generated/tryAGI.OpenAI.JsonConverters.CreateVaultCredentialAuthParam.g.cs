#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateVaultCredentialAuthParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.CreateVaultCredentialAuthParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.CreateVaultCredentialAuthParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth? mcpOauth = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType.McpOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth)}");
                mcpOauth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer? staticBearer = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType.StaticBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer)}");
                staticBearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable? environmentVariable = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateVaultCredentialAuthParamDiscriminatorType.EnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable)}");
                environmentVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.CreateVaultCredentialAuthParam(
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
            global::tryAGI.OpenAI.CreateVaultCredentialAuthParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcpOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamMcpOauth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpOauth!, typeInfo);
            }
            else if (value.IsStaticBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamStaticBearer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StaticBearer!, typeInfo);
            }
            else if (value.IsEnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateVaultCredentialAuthParamEnvironmentVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentVariable!, typeInfo);
            }
        }
    }
}