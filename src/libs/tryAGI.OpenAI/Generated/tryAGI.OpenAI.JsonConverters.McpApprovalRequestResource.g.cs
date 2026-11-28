#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class McpApprovalRequestResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.McpApprovalRequestResource>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.McpApprovalRequestResource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall? mcpToolCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.McpApprovalRequestResourceDiscriminatorType.McpToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall)}");
                mcpToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.McpApprovalRequestResource(
                discriminator?.Type,
                mcpToolCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.McpApprovalRequestResource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsMcpToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.McpApprovalRequestResourceMcpToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMcpToolCall(), typeInfo);
            }
        }
    }
}