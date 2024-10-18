#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.ChatCompletionRequestMessageContentPartText? text = default;
            if (discriminator?.Type == global::OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestMessageContentPartText)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ChatCompletionRequestMessageContentPartImage? image = default;
            if (discriminator?.Type == global::OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestMessageContentPartImage)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ChatCompletionRequestMessageContentPartAudio? audio = default;
            if (discriminator?.Type == global::OpenAI.ChatCompletionRequestUserMessageContentPartDiscriminatorType.InputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ChatCompletionRequestMessageContentPartAudio)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ChatCompletionRequestUserMessageContentPart(
                discriminator?.Type,
                text,
                image,
                audio
                );

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
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ChatCompletionRequestMessageContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ChatCompletionRequestMessageContentPartAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ChatCompletionRequestMessageContentPartAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio, typeInfo);
            }
        }
    }
}