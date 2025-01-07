#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.AnnotationsItem2>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.AnnotationsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? fileCitation = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject)}");
                fileCitation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? filePath = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject)}");
                filePath = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::tryAGI.OpenAI.AnnotationsItem2(
                discriminator?.Type,
                fileCitation,
                filePath
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.AnnotationsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileCitation, typeInfo);
            }
            else if (value.IsFilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.MessageDeltaContentTextAnnotationsFilePathObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FilePath, typeInfo);
            }
        }
    }
}