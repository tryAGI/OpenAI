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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("start")) __score0++;
            if (__jsonProps.Contains("end")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("speaker")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("delta")) __score1++;
            if (__jsonProps.Contains("logprobs")) __score1++;
            if (__jsonProps.Contains("segment_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("text")) __score2++;
            if (__jsonProps.Contains("logprobs")) __score2++;
            if (__jsonProps.Contains("usage")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::tryAGI.OpenAI.TranscriptTextSegmentEvent? transcriptTextSegment = default;
            global::tryAGI.OpenAI.TranscriptTextDeltaEvent? transcriptTextDelta = default;
            global::tryAGI.OpenAI.TranscriptTextDoneEvent? transcriptTextDone = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextSegmentEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent).Name}");
                        transcriptTextSegment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent).Name}");
                        transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent).Name}");
                        transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (transcriptTextSegment == null && transcriptTextDelta == null && transcriptTextDone == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextSegmentEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextSegmentEvent).Name}");
                    transcriptTextSegment = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDeltaEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDeltaEvent).Name}");
                    transcriptTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TranscriptTextDoneEvent> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TranscriptTextDoneEvent).Name}");
                    transcriptTextDone = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.CreateTranscriptionResponseStreamEvent(
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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TranscriptTextSegment, typeInfo);
            }
            else if (value.IsTranscriptTextDelta)
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