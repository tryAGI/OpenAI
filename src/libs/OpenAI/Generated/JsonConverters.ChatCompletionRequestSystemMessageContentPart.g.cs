#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestSystemMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ChatCompletionRequestSystemMessageContentPart>
    {
        /// <inheritdoc />
        public override global::OpenAI.ChatCompletionRequestSystemMessageContentPart Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::OpenAI.ChatCompletionRequestMessageContentPartText? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::OpenAI.ChatCompletionRequestSystemMessageContentPart(
                text
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}>");
            }

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ChatCompletionRequestSystemMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}> object.");
            }

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}