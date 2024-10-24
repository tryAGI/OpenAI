#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RunStepObjectStepDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RunStepObjectStepDetails>
    {
        /// <inheritdoc />
        public override global::OpenAI.RunStepObjectStepDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepObjectStepDetailsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepObjectStepDetailsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepObjectStepDetailsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.RunStepDetailsMessageCreationObject? messageCreation = default;
            if (discriminator?.Type == global::OpenAI.RunStepObjectStepDetailsDiscriminatorType.MessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsMessageCreationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsMessageCreationObject)}");
                messageCreation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RunStepDetailsToolCallsObject? toolCalls = default;
            if (discriminator?.Type == global::OpenAI.RunStepObjectStepDetailsDiscriminatorType.ToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsObject)}");
                toolCalls = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.RunStepObjectStepDetails(
                discriminator?.Type,
                messageCreation,
                toolCalls
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RunStepObjectStepDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsMessageCreationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsMessageCreationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageCreation, typeInfo);
            }
            else if (value.IsToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsToolCallsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCalls, typeInfo);
            }
        }
    }
}