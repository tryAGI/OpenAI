#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ComputerUseApprovalResponseParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ComputerUseApprovalResponseParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ComputerUseApprovalResponseParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication? browserAuthentication = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType.BrowserAuthentication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication)}");
                browserAuthentication = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam? browserOriginAccess = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.ComputerUseApprovalResponseParamDiscriminatorType.BrowserOriginAccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam)}");
                browserOriginAccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.ComputerUseApprovalResponseParam(
                discriminator?.Type,
                browserAuthentication,

                browserOriginAccess
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ComputerUseApprovalResponseParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBrowserAuthentication)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserAuthentication).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserAuthentication(), typeInfo);
            }
            else if (value.IsBrowserOriginAccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerUseApprovalResponseParamBrowserOriginAccessParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBrowserOriginAccess(), typeInfo);
            }
        }
    }
}