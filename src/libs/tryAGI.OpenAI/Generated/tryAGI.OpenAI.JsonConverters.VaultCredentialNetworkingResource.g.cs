#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class VaultCredentialNetworkingResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.VaultCredentialNetworkingResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.VaultCredentialNetworkingResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted? unrestricted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType.Unrestricted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted)}");
                unrestricted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited? limited = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialNetworkingResourceDiscriminatorType.Limited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited)}");
                limited = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.VaultCredentialNetworkingResource(
                discriminator?.Type,
                unrestricted,

                limited
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.VaultCredentialNetworkingResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnrestricted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceUnrestricted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unrestricted!, typeInfo);
            }
            else if (value.IsLimited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingResourceLimited).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Limited!, typeInfo);
            }
        }
    }
}