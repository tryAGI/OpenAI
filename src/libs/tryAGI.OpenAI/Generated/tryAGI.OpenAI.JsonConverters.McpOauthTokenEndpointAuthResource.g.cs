#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class McpOauthTokenEndpointAuthResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone? none = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic? clientSecretBasic = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType.ClientSecretBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic)}");
                clientSecretBasic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost? clientSecretPost = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceDiscriminatorType.ClientSecretPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost)}");
                clientSecretPost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource(
                discriminator?.Type,
                none,

                clientSecretBasic,

                clientSecretPost
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
            else if (value.IsClientSecretBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretBasic).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientSecretBasic!, typeInfo);
            }
            else if (value.IsClientSecretPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.McpOauthTokenEndpointAuthResourceClientSecretPost).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientSecretPost!, typeInfo);
            }
        }
    }
}