#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class NetworkPolicy4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.NetworkPolicy4>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.NetworkPolicy4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam? disabled = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam? allowlist = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaContainerAutoParamNetworkPolicyDiscriminatorType.Allowlist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam)}");
                allowlist = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.NetworkPolicy4(
                discriminator?.Type,
                disabled,

                allowlist
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.NetworkPolicy4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyDisabledParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled!, typeInfo);
            }
            else if (value.IsAllowlist)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaContainerNetworkPolicyAllowlistParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Allowlist!, typeInfo);
            }
        }
    }
}