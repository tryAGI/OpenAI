#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateMcpOauthTokenEndpointAuthParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone? none = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic? clientSecretBasic = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic)}");
                clientSecretBasic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost? clientSecretPost = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost)}");
                clientSecretPost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam(
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
            global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamNone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
            else if (value.IsClientSecretBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretBasic).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientSecretBasic!, typeInfo);
            }
            else if (value.IsClientSecretPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.CreateMcpOauthTokenEndpointAuthParamClientSecretPost).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientSecretPost!, typeInfo);
            }
        }
    }
}