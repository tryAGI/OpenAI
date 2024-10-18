#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <inheritdoc />
        public override global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? logs = default;
            if (discriminator?.Type == global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? image = default;
            if (discriminator?.Type == global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
                discriminator?.Type,
                logs,
                image
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLogs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Logs, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}