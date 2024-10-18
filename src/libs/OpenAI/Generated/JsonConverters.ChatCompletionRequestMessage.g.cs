#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ChatCompletionRequestMessage>
    {
        /// <inheritdoc />
        public override global::OpenAI.ChatCompletionRequestMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.ChatCompletionRequestSystemMessage? system = default;
            if (discriminator?.Role == global::OpenAI.ChatCompletionRequestMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestSystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestSystemMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ChatCompletionRequestUserMessage? user = default;
            if (discriminator?.Role == global::OpenAI.ChatCompletionRequestMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestUserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestUserMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ChatCompletionRequestAssistantMessage? assistant = default;
            if (discriminator?.Role == global::OpenAI.ChatCompletionRequestMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestAssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestAssistantMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ChatCompletionRequestToolMessage? tool = default;
            if (discriminator?.Role == global::OpenAI.ChatCompletionRequestMessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestToolMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ChatCompletionRequestFunctionMessage? function = default;
            if (discriminator?.Role == global::OpenAI.ChatCompletionRequestMessageDiscriminatorRole.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestFunctionMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestFunctionMessage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ChatCompletionRequestMessage(
                discriminator?.Role,
                system,
                user,
                assistant,
                tool,
                function
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ChatCompletionRequestMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User, typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Assistant, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestFunctionMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestFunctionMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestFunctionMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
        }
    }
}