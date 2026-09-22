#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class SessionInputParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.SessionInputParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.SessionInputParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionInputParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage? agentSessionInputMessage = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionInputParamDiscriminatorType.AgentSessionInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage)}");
                agentSessionInputMessage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel? agentSessionInputCancel = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionInputParamDiscriminatorType.AgentSessionInputCancel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel)}");
                agentSessionInputCancel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult? agentSessionInputToolResult = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionInputParamDiscriminatorType.AgentSessionInputToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult)}");
                agentSessionInputToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.SessionInputParam(
                discriminator?.Type,
                agentSessionInputMessage,

                agentSessionInputCancel,

                agentSessionInputToolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.SessionInputParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgentSessionInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionInputMessage!, typeInfo);
            }
            else if (value.IsAgentSessionInputCancel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputCancel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionInputCancel!, typeInfo);
            }
            else if (value.IsAgentSessionInputToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionInputParamAgentSessionInputToolResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionInputToolResult!, typeInfo);
            }
        }
    }
}