#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ContentVariant2ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ContentVariant2Item>
    {
        /// <inheritdoc />
        public override global::OpenAI.ContentVariant2Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateMessageRequestContentVariant2ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateMessageRequestContentVariant2ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateMessageRequestContentVariant2ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.MessageContentImageFileObject? messageImageFileObject = default;
            if (discriminator?.Type == global::OpenAI.CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentImageFileObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentImageFileObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageContentImageFileObject)}");
                messageImageFileObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageContentImageUrlObject? messageImageUrlObject = default;
            if (discriminator?.Type == global::OpenAI.CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageContentImageUrlObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageContentImageUrlObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageContentImageUrlObject)}");
                messageImageUrlObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.MessageRequestContentTextObject? messageRequestTextObject = default;
            if (discriminator?.Type == global::OpenAI.CreateMessageRequestContentVariant2ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageRequestContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageRequestContentTextObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.MessageRequestContentTextObject)}");
                messageRequestTextObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ContentVariant2Item(
                discriminator?.Type,
                messageImageFileObject,
                messageImageUrlObject,
                messageRequestTextObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ContentVariant2Item value,
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
            else if (value.IsMessageRequestTextObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.MessageRequestContentTextObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.MessageRequestContentTextObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.MessageRequestContentTextObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageRequestTextObject, typeInfo);
            }
        }
    }
}