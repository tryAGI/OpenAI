#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class CreateTranscriptionResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.TranscriptTextSegmentEvent? transcriptTextSegment = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextSegmentEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent)}");
                transcriptTextSegment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.TranscriptTextDeltaEvent? transcriptTextDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent)}");
                transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.TranscriptTextDoneEvent? transcriptTextDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.TranscriptTextDoneEvent)}");
                transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent(
                discriminator?.Type,
                transcriptTextSegment,

                transcriptTextDelta,

                transcriptTextDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptTextSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextSegmentEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextSegment!, typeInfo);
            }
            else if (value.IsTranscriptTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDelta!, typeInfo);
            }
            else if (value.IsTranscriptTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDone!, typeInfo);
            }
        }
    }
}