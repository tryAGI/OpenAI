#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class VaultCredentialNetworkingParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.VaultCredentialNetworkingParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.VaultCredentialNetworkingParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted? unrestricted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType.Unrestricted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted)}");
                unrestricted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited? limited = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.VaultCredentialNetworkingParamDiscriminatorType.Limited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited)}");
                limited = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.VaultCredentialNetworkingParam(
                discriminator?.Type,
                unrestricted,

                limited
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.VaultCredentialNetworkingParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnrestricted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamUnrestricted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unrestricted!, typeInfo);
            }
            else if (value.IsLimited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.VaultCredentialNetworkingParamLimited).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Limited!, typeInfo);
            }
        }
    }
}