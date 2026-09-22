#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RotateMcpOauthTokenEndpointAuthParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic? clientSecretBasic = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic)}");
                clientSecretBasic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost? clientSecretPost = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamDiscriminatorType.ClientSecretPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost)}");
                clientSecretPost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam(
                discriminator?.Type,
                clientSecretBasic,

                clientSecretPost
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClientSecretBasic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretBasic).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientSecretBasic!, typeInfo);
            }
            else if (value.IsClientSecretPost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RotateMcpOauthTokenEndpointAuthParamClientSecretPost).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientSecretPost!, typeInfo);
            }
        }
    }
}