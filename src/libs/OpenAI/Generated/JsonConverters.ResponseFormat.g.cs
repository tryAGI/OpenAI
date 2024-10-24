#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ResponseFormat>
    {
        /// <inheritdoc />
        public override global::OpenAI.ResponseFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.CreateChatCompletionRequestResponseFormatDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.CreateChatCompletionRequestResponseFormatDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.CreateChatCompletionRequestResponseFormatDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.ResponseFormatText? text = default;
            if (discriminator?.Type == global::OpenAI.CreateChatCompletionRequestResponseFormatDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ResponseFormatText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ResponseFormatText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ResponseFormatJsonObject? jsonObject = default;
            if (discriminator?.Type == global::OpenAI.CreateChatCompletionRequestResponseFormatDiscriminatorType.JsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ResponseFormatJsonObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ResponseFormatJsonObject)}");
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.ResponseFormatJsonSchema? jsonSchema = default;
            if (discriminator?.Type == global::OpenAI.CreateChatCompletionRequestResponseFormatDiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ResponseFormatJsonSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ResponseFormatJsonSchema)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ResponseFormat(
                discriminator?.Type,
                text,
                jsonObject,
                jsonSchema
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ResponseFormatText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ResponseFormatText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsJsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ResponseFormatJsonObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ResponseFormatJsonObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonObject, typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ResponseFormatJsonSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ResponseFormatJsonSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JsonSchema, typeInfo);
            }
        }
    }
}