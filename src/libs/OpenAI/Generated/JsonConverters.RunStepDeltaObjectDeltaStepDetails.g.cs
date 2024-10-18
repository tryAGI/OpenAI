#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RunStepDeltaObjectDeltaStepDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RunStepDeltaObjectDeltaStepDetails>
    {
        /// <inheritdoc />
        public override global::OpenAI.RunStepDeltaObjectDeltaStepDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject? messageCreation = default;
            if (discriminator?.Type == global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.MessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RunStepDeltaStepDetailsToolCallsObject? toolCalls = default;
            if (discriminator?.Type == global::OpenAI.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.ToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.RunStepDeltaObjectDeltaStepDetails(
                discriminator?.Type,
                messageCreation,
                toolCalls
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RunStepDeltaObjectDeltaStepDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDeltaStepDetailsMessageCreationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageCreation, typeInfo);
            }
            else if (value.IsToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCalls, typeInfo);
            }
        }
    }
}