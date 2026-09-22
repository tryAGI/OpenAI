#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class BetaMCPToolCallErrorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.BetaMCPToolCallError>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.BetaMCPToolCallError Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.BetaMCPProtocolError? mcpProtocolError = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType.McpProtocolError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaMCPProtocolError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaMCPProtocolError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaMCPProtocolError)}");
                mcpProtocolError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaMCPToolExecutionError? mcpToolExecutionError = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType.McpToolExecutionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaMCPToolExecutionError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaMCPToolExecutionError)}");
                mcpToolExecutionError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaHTTPError? httpError = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaMCPToolCallErrorDiscriminatorType.HttpError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaHTTPError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaHTTPError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaHTTPError)}");
                httpError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.BetaMCPToolCallError(
                discriminator?.Type,
                mcpProtocolError,

                mcpToolExecutionError,

                httpError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.BetaMCPToolCallError value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMcpProtocolError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaMCPProtocolError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaMCPProtocolError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaMCPProtocolError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpProtocolError!, typeInfo);
            }
            else if (value.IsMcpToolExecutionError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaMCPToolExecutionError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaMCPToolExecutionError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpToolExecutionError!, typeInfo);
            }
            else if (value.IsHttpError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaHTTPError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaHTTPError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaHTTPError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HttpError!, typeInfo);
            }
        }
    }
}