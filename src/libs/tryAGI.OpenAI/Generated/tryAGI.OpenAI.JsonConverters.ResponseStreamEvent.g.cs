#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ResponseStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ResponseStreamEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ResponseStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseAudioDeltaEvent? audioDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent).Name}");
                audioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseAudioDoneEvent? audioDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent).Name}");
                audioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent? audioTranscriptDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent).Name}");
                audioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent? audioTranscriptDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent).Name}");
                audioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent? codeInterpreterCallDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                codeInterpreterCallDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent? codeInterpreterCallDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                codeInterpreterCallDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent? codeInterpreterCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent).Name}");
                codeInterpreterCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent? codeInterpreterCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent).Name}");
                codeInterpreterCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent? codeInterpreterCallInterpreting = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                codeInterpreterCallInterpreting = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCompletedEvent? completed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCompletedEvent).Name}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseContentPartAddedEvent? contentPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent).Name}");
                contentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseContentPartDoneEvent? contentPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent).Name}");
                contentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseCreatedEvent? created = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCreatedEvent).Name}");
                created = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseErrorEvent? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseErrorEvent).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent? fileSearchCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent).Name}");
                fileSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent? fileSearchCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent).Name}");
                fileSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent? fileSearchCallSearching = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent).Name}");
                fileSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent? functionCallArgumentsDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                functionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent? functionCallArgumentsDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent).Name}");
                functionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseInProgressEvent? inProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseInProgressEvent).Name}");
                inProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseFailedEvent? failed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFailedEvent).Name}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseIncompleteEvent? incomplete = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseIncompleteEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent).Name}");
                incomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseOutputItemAddedEvent? outputItemAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent).Name}");
                outputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseOutputItemDoneEvent? outputItemDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent).Name}");
                outputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent? reasoningSummaryPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent).Name}");
                reasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent? reasoningSummaryPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent).Name}");
                reasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent? reasoningSummaryTextDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent).Name}");
                reasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent? reasoningSummaryTextDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent).Name}");
                reasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseRefusalDeltaEvent? refusalDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent).Name}");
                refusalDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseRefusalDoneEvent? refusalDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseRefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent).Name}");
                refusalDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent? textAnnotationDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent).Name}");
                textAnnotationDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseTextDeltaEvent? textDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent).Name}");
                textDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseTextDoneEvent? textDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent).Name}");
                textDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent? webSearchCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent).Name}");
                webSearchCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent? webSearchCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent).Name}");
                webSearchCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent? webSearchCallSearching = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent).Name}");
                webSearchCallSearching = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::tryAGI.OpenAI.ResponseStreamEvent(
                audioDelta,
                audioDone,
                audioTranscriptDelta,
                audioTranscriptDone,
                codeInterpreterCallDelta,
                codeInterpreterCallDone,
                codeInterpreterCallCompleted,
                codeInterpreterCallInProgress,
                codeInterpreterCallInterpreting,
                completed,
                contentPartAdded,
                contentPartDone,
                created,
                error,
                fileSearchCallCompleted,
                fileSearchCallInProgress,
                fileSearchCallSearching,
                functionCallArgumentsDelta,
                functionCallArgumentsDone,
                inProgress,
                failed,
                incomplete,
                outputItemAdded,
                outputItemDone,
                reasoningSummaryPartAdded,
                reasoningSummaryPartDone,
                reasoningSummaryTextDelta,
                reasoningSummaryTextDone,
                refusalDelta,
                refusalDone,
                textAnnotationDelta,
                textDelta,
                textDone,
                webSearchCallCompleted,
                webSearchCallInProgress,
                webSearchCallSearching
                );

            if (audioDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioTranscriptDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (audioTranscriptDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (codeInterpreterCallInterpreting != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (completed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseContentPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (contentPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseContentPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (created != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCreatedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCreatedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseErrorEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchCallSearching != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionCallArgumentsDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionCallArgumentsDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (failed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFailedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFailedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (incomplete != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseIncompleteEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputItemAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputItemDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryTextDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoningSummaryTextDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (refusalDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (refusalDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseRefusalDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textAnnotationDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (textDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextDoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchCallSearching != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ResponseStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioDelta, typeInfo);
            }
            else if (value.IsAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioDone, typeInfo);
            }
            else if (value.IsAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioTranscriptDelta, typeInfo);
            }
            else if (value.IsAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseAudioTranscriptDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioTranscriptDone, typeInfo);
            }
            else if (value.IsCodeInterpreterCallDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallDelta, typeInfo);
            }
            else if (value.IsCodeInterpreterCallDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCodeDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallDone, typeInfo);
            }
            else if (value.IsCodeInterpreterCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallCompleted, typeInfo);
            }
            else if (value.IsCodeInterpreterCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallInProgress, typeInfo);
            }
            else if (value.IsCodeInterpreterCallInterpreting)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCodeInterpreterCallInterpretingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCallInterpreting, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed, typeInfo);
            }
            else if (value.IsContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseContentPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseContentPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartAdded, typeInfo);
            }
            else if (value.IsContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseContentPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseContentPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartDone, typeInfo);
            }
            else if (value.IsCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseCreatedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseCreatedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseCreatedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Created, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsFileSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCallCompleted, typeInfo);
            }
            else if (value.IsFileSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCallInProgress, typeInfo);
            }
            else if (value.IsFileSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFileSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCallSearching, typeInfo);
            }
            else if (value.IsFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFunctionCallArgumentsDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InProgress, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseFailedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseFailedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseFailedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
            else if (value.IsIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseIncompleteEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseIncompleteEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Incomplete, typeInfo);
            }
            else if (value.IsOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseOutputItemAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseOutputItemAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemAdded, typeInfo);
            }
            else if (value.IsOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseOutputItemDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseOutputItemDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemDone, typeInfo);
            }
            else if (value.IsReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartAddedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryPartAdded, typeInfo);
            }
            else if (value.IsReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryPartDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryPartDone, typeInfo);
            }
            else if (value.IsReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryTextDelta, typeInfo);
            }
            else if (value.IsReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseReasoningSummaryTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningSummaryTextDone, typeInfo);
            }
            else if (value.IsRefusalDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseRefusalDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseRefusalDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefusalDelta, typeInfo);
            }
            else if (value.IsRefusalDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseRefusalDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseRefusalDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RefusalDone, typeInfo);
            }
            else if (value.IsTextAnnotationDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextAnnotationDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextAnnotationDelta, typeInfo);
            }
            else if (value.IsTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDelta, typeInfo);
            }
            else if (value.IsTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseTextDoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseTextDoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextDone, typeInfo);
            }
            else if (value.IsWebSearchCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallCompletedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCallCompleted, typeInfo);
            }
            else if (value.IsWebSearchCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallInProgressEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCallInProgress, typeInfo);
            }
            else if (value.IsWebSearchCallSearching)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ResponseWebSearchCallSearchingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCallSearching, typeInfo);
            }
        }
    }
}