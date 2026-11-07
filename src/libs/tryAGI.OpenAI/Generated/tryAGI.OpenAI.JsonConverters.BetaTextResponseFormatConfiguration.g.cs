#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class BetaTextResponseFormatConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.BetaResponseFormatText? text = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseFormatText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseFormatText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema? jsonSchema = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminatorType.JsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema)}");
                jsonSchema = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.BetaResponseFormatJsonObject? jsonObject = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.BetaTextResponseFormatConfigurationDiscriminatorType.JsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseFormatJsonObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject)}");
                jsonObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration(
                discriminator?.Type,
                text,

                jsonSchema,

                jsonObject
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.BetaTextResponseFormatConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseFormatText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseFormatText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsJsonSchema)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaTextResponseFormatJsonSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJsonSchema(), typeInfo);
            }
            else if (value.IsJsonObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.BetaResponseFormatJsonObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.BetaResponseFormatJsonObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJsonObject(), typeInfo);
            }
        }
    }
}