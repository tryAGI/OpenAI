#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ComputerUseApprovalRequestKindResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication? browserAuthentication = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType.BrowserAuthentication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication)}");
                browserAuthentication = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess? browserOriginAccess = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceDiscriminatorType.BrowserOriginAccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess)}");
                browserOriginAccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource(
                discriminator?.Type,
                browserAuthentication,

                browserOriginAccess
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBrowserAuthentication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserAuthentication).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserAuthentication(), typeInfo);
            }
            else if (value.IsBrowserOriginAccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerUseApprovalRequestKindResourceBrowserOriginAccess).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserOriginAccess(), typeInfo);
            }
        }
    }
}