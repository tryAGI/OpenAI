#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AnnotationsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.AnnotationsItem2>
    {
        /// <inheritdoc />
        public override global::OpenAI.AnnotationsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject? messageDeltaContentTextFileCitationObject = default;
            if (discriminator?.Type == global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FileCitation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject)}");
                messageDeltaContentTextFileCitationObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject? messageDeltaContentTextFilePathObject = default;
            if (discriminator?.Type == global::OpenAI.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FilePath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject)}");
                messageDeltaContentTextFilePathObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.AnnotationsItem2(
                discriminator?.Type,
                messageDeltaContentTextFileCitationObject,
                messageDeltaContentTextFilePathObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.AnnotationsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageDeltaContentTextFileCitationObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFileCitationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaContentTextFileCitationObject, typeInfo);
            }
            else if (value.IsMessageDeltaContentTextFilePathObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageDeltaContentTextAnnotationsFilePathObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaContentTextFilePathObject, typeInfo);
            }
        }
    }
}