#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class VaultCredentialAuthResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.VaultCredentialAuthResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.VaultCredentialAuthResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth? mcpOauth = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType.McpOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth)}");
                mcpOauth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer? staticBearer = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType.StaticBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer)}");
                staticBearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable? environmentVariable = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialAuthResourceDiscriminatorType.EnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable)}");
                environmentVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.VaultCredentialAuthResource(
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
            global::tryAGI.OpenAI.VaultCredentialAuthResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcpOauth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceMcpOauth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpOauth!, typeInfo);
            }
            else if (value.IsStaticBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceStaticBearer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StaticBearer!, typeInfo);
            }
            else if (value.IsEnvironmentVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialAuthResourceEnvironmentVariable).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentVariable!, typeInfo);
            }
        }
    }
}