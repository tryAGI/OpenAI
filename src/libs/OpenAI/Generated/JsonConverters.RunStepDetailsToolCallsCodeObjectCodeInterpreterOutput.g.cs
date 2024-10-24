#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <inheritdoc />
        public override global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject? logs = default;
            if (discriminator?.Type == global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject)}");
                logs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject? image = default;
            if (discriminator?.Type == global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
                discriminator?.Type,
                logs,
                image
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RunStepDetailsToolCallsCodeObjectCodeInterpreterOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLogs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputLogsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Logs, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsToolCallsCodeOutputImageObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}