#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ContentItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ContentItem2>
    {
        /// <inheritdoc />
        public override global::OpenAI.ContentItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageObjectContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageObjectContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageObjectContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.MessageContentImageFileObject? messageImageFileObject = default;
            if (discriminator?.Type == global::OpenAI.MessageObjectContentItemDiscriminatorType.ImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentImageFileObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageContentImageFileObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageContentImageUrlObject? messageImageUrlObject = default;
            if (discriminator?.Type == global::OpenAI.MessageObjectContentItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentImageUrlObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageContentImageUrlObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageContentTextObject? messageTextObject = default;
            if (discriminator?.Type == global::OpenAI.MessageObjectContentItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentTextObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageContentTextObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageContentRefusalObject? messageRefusalObject = default;
            if (discriminator?.Type == global::OpenAI.MessageObjectContentItemDiscriminatorType.Refusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentRefusalObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageContentRefusalObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ContentItem2(
                discriminator?.Type,
                messageImageFileObject,
                messageImageUrlObject,
                messageTextObject,
                messageRefusalObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ContentItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageImageFileObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentImageFileObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageContentImageFileObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageImageFileObject, typeInfo);
            }
            else if (value.IsMessageImageUrlObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentImageUrlObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageContentImageUrlObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageImageUrlObject, typeInfo);
            }
            else if (value.IsMessageTextObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentTextObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageContentTextObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageTextObject, typeInfo);
            }
            else if (value.IsMessageRefusalObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentRefusalObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentRefusalObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageContentRefusalObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageRefusalObject, typeInfo);
            }
        }
    }
}