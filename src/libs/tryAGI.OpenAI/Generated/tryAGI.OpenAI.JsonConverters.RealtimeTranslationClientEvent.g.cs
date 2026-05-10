#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeTranslationClientEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeTranslationClientEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeTranslationClientEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate? sessionUpdate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType.SessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate)}");
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend? sessionInputAudioBufferAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType.SessionInputAudioBufferAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend)}");
                sessionInputAudioBufferAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose? sessionClose = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.RealtimeTranslationClientEventDiscriminatorType.SessionClose)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose)}");
                sessionClose = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.RealtimeTranslationClientEvent(
                discriminator?.Type,
                sessionUpdate,

                sessionInputAudioBufferAppend,

                sessionClose
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeTranslationClientEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate!, typeInfo);
            }
            else if (value.IsSessionInputAudioBufferAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioBufferAppend!, typeInfo);
            }
            else if (value.IsSessionClose)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeTranslationClientEventSessionClose).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionClose!, typeInfo);
            }
        }
    }
}