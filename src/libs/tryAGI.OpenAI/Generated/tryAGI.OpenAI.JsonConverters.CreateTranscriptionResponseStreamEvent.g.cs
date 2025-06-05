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

            var
            readerCopy = reader;
            global::tryAGI.OpenAI.TranscriptTextDeltaEvent? transcriptTextDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent).Name}");
                transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.TranscriptTextDoneEvent? transcriptTextDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent).Name}");
                transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent(
                transcriptTextDelta,
                transcriptTextDone
                );

            if (transcriptTextDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (transcriptTextDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTranscriptTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDelta, typeInfo);
            }
            else if (value.IsTranscriptTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextDone, typeInfo);
            }
        }
    }
}