#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class DecisionInputMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.DecisionInputMessage>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.DecisionInputMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.DecisionInputMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.DecisionInputUserMessage? user = default;
            if (discriminator?.Role == global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputUserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.DecisionInputUserMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.DecisionInputDeveloperMessage? developer = default;
            if (discriminator?.Role == global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole.Developer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputDeveloperMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.DecisionInputDeveloperMessage)}");
                developer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.DecisionInputSystemMessage? system = default;
            if (discriminator?.Role == global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputSystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.DecisionInputSystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.DecisionInputAssistantMessage? assistant = default;
            if (discriminator?.Role == global::tryAGI.OpenAI.DecisionInputMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputAssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.DecisionInputAssistantMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.DecisionInputMessage(
                discriminator?.Role,
                user,

                developer,

                system,

                assistant
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.DecisionInputMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.DecisionInputUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUser(), typeInfo);
            }
            else if (value.IsDeveloper)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputDeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.DecisionInputDeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDeveloper(), typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.DecisionInputSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSystem(), typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.DecisionInputAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.DecisionInputAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.DecisionInputAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAssistant(), typeInfo);
            }
        }
    }
}