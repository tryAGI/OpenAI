#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestUserMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ChatCompletionRequestUserMessageContentPart>
    {
        /// <inheritdoc />
        public override global::OpenAI.ChatCompletionRequestUserMessageContentPart Read(
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

            readerCopy = reader;
            global::OpenAI.ChatCompletionRequestMessageContentPartImage? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::OpenAI.ChatCompletionRequestUserMessageContentPart(
                text,

                image
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for OneOf<{typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}, {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage).Name}>");
            }

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ChatCompletionRequestUserMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid OneOf<{typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}, {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage).Name}> object.");
            }

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }

            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}