#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ContentItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ContentItem>
    {
        /// <inheritdoc />
        public override global::OpenAI.ContentItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.MessageDeltaContentImageFileObject? messageDeltaImageFileObject = default;
            if (discriminator?.Type == global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentImageFileObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentImageFileObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageDeltaContentTextObject? messageDeltaTextObject = default;
            if (discriminator?.Type == global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentTextObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageDeltaContentRefusalObject? messageDeltaRefusalObject = default;
            if (discriminator?.Type == global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType.Refusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentRefusalObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentRefusalObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageDeltaContentImageUrlObject? messageDeltaImageUrlObject = default;
            if (discriminator?.Type == global::OpenAI.MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentImageUrlObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageDeltaContentImageUrlObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ContentItem(
                discriminator?.Type,
                messageDeltaImageFileObject,
                messageDeltaTextObject,
                messageDeltaRefusalObject,
                messageDeltaImageUrlObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ContentItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageDeltaImageFileObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentImageFileObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageDeltaContentImageFileObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaImageFileObject, typeInfo);
            }
            else if (value.IsMessageDeltaTextObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentTextObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageDeltaContentTextObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaTextObject, typeInfo);
            }
            else if (value.IsMessageDeltaRefusalObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentRefusalObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageDeltaContentRefusalObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaRefusalObject, typeInfo);
            }
            else if (value.IsMessageDeltaImageUrlObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageDeltaContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageDeltaContentImageUrlObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageDeltaContentImageUrlObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageDeltaImageUrlObject, typeInfo);
            }
        }
    }
}