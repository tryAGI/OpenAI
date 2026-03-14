#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RealtimeServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RealtimeServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationCreated? conversationCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated).Name}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated? conversationItemCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated).Name}");
                conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted? conversationItemDeleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted).Name}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta? conversationItemInputAudioTranscriptionDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                conversationItemInputAudioTranscriptionDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved? conversationItemRetrieved = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved).Name}");
                conversationItemRetrieved = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated? conversationItemTruncated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated).Name}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventError? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventError).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared? inputAudioBufferCleared = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared).Name}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted).Name}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived? inputAudioBufferDtmfEventReceived = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived).Name}");
                inputAudioBufferDtmfEventReceived = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated? rateLimitsUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated).Name}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta? responseOutputAudioDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta).Name}");
                responseOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone? responseOutputAudioDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone).Name}");
                responseOutputAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta? responseOutputAudioTranscriptDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                responseOutputAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone? responseOutputAudioTranscriptDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                responseOutputAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded? responseContentPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded).Name}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone? responseContentPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone).Name}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseCreated? responseCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated).Name}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseDone? responseDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone).Name}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded? responseOutputItemAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded).Name}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone? responseOutputItemDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone).Name}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta? responseOutputTextDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta).Name}");
                responseOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone? responseOutputTextDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone).Name}");
                responseOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventSessionCreated? sessionCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated).Name}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated? sessionUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated).Name}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted? outputAudioBufferStarted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted).Name}");
                outputAudioBufferStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped? outputAudioBufferStopped = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped).Name}");
                outputAudioBufferStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared? outputAudioBufferCleared = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared).Name}");
                outputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded? conversationItemAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded).Name}");
                conversationItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone? conversationItemDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone).Name}");
                conversationItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered? inputAudioBufferTimeoutTriggered = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered).Name}");
                inputAudioBufferTimeoutTriggered = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment? conversationItemInputAudioTranscriptionSegment = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment).Name}");
                conversationItemInputAudioTranscriptionSegment = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress? mcpListToolsInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress).Name}");
                mcpListToolsInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted? mcpListToolsCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted).Name}");
                mcpListToolsCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed? mcpListToolsFailed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed).Name}");
                mcpListToolsFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta? responseMcpCallArgumentsDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta).Name}");
                responseMcpCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone? responseMcpCallArgumentsDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone).Name}");
                responseMcpCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress? responseMcpCallInProgress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress).Name}");
                responseMcpCallInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted? responseMcpCallCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted).Name}");
                responseMcpCallCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed? responseMcpCallFailed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed).Name}");
                responseMcpCallFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::tryAGI.OpenAI.RealtimeServerEvent(
                conversationCreated,

                conversationItemCreated,

                conversationItemDeleted,

                conversationItemInputAudioTranscriptionCompleted,

                conversationItemInputAudioTranscriptionDelta,

                conversationItemInputAudioTranscriptionFailed,

                conversationItemRetrieved,

                conversationItemTruncated,

                error,

                inputAudioBufferCleared,

                inputAudioBufferCommitted,

                inputAudioBufferDtmfEventReceived,

                inputAudioBufferSpeechStarted,

                inputAudioBufferSpeechStopped,

                rateLimitsUpdated,

                responseOutputAudioDelta,

                responseOutputAudioDone,

                responseOutputAudioTranscriptDelta,

                responseOutputAudioTranscriptDone,

                responseContentPartAdded,

                responseContentPartDone,

                responseCreated,

                responseDone,

                responseFunctionCallArgumentsDelta,

                responseFunctionCallArgumentsDone,

                responseOutputItemAdded,

                responseOutputItemDone,

                responseOutputTextDelta,

                responseOutputTextDone,

                sessionCreated,

                sessionUpdated,

                outputAudioBufferStarted,

                outputAudioBufferStopped,

                outputAudioBufferCleared,

                conversationItemAdded,

                conversationItemDone,

                inputAudioBufferTimeoutTriggered,

                conversationItemInputAudioTranscriptionSegment,

                mcpListToolsInProgress,

                mcpListToolsCompleted,

                mcpListToolsFailed,

                responseMcpCallArgumentsDelta,

                responseMcpCallArgumentsDone,

                responseMcpCallInProgress,

                responseMcpCallCompleted,

                responseMcpCallFailed
                );

            if (conversationCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemDeleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionFailed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemRetrieved != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemTruncated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventError).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCleared != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCommitted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferDtmfEventReceived != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferSpeechStarted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferSpeechStopped != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (rateLimitsUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputAudioDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputAudioDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputAudioTranscriptDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputAudioTranscriptDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseContentPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseContentPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseFunctionCallArgumentsDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseFunctionCallArgumentsDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputItemAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputItemDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputTextDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputTextDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferStarted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferStopped != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (outputAudioBufferCleared != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferTimeoutTriggered != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionSegment != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mcpListToolsInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mcpListToolsCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mcpListToolsFailed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseMcpCallArgumentsDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseMcpCallArgumentsDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseMcpCallInProgress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseMcpCallCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseMcpCallFailed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RealtimeServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionDelta, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeInfo);
            }
            else if (value.IsConversationItemRetrieved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemRetrieved).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieved, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeInfo);
            }
            else if (value.IsInputAudioBufferDtmfEventReceived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferDtmfEventReceived).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferDtmfEventReceived, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeInfo);
            }
            else if (value.IsResponseOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDelta, typeInfo);
            }
            else if (value.IsResponseOutputAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioDone, typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDelta, typeInfo);
            }
            else if (value.IsResponseOutputAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputAudioTranscriptDone, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeInfo);
            }
            else if (value.IsResponseOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDelta, typeInfo);
            }
            else if (value.IsResponseOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputTextDone, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeInfo);
            }
            else if (value.IsOutputAudioBufferStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStarted, typeInfo);
            }
            else if (value.IsOutputAudioBufferStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferStopped, typeInfo);
            }
            else if (value.IsOutputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventOutputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferCleared, typeInfo);
            }
            else if (value.IsConversationItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemAdded, typeInfo);
            }
            else if (value.IsConversationItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDone, typeInfo);
            }
            else if (value.IsInputAudioBufferTimeoutTriggered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventInputAudioBufferTimeoutTriggered).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferTimeoutTriggered, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionSegment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventConversationItemInputAudioTranscriptionSegment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionSegment, typeInfo);
            }
            else if (value.IsMcpListToolsInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsInProgress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsInProgress, typeInfo);
            }
            else if (value.IsMcpListToolsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsCompleted, typeInfo);
            }
            else if (value.IsMcpListToolsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventMCPListToolsFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsFailed, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDelta, typeInfo);
            }
            else if (value.IsResponseMcpCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallArgumentsDone, typeInfo);
            }
            else if (value.IsResponseMcpCallInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallInProgress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallInProgress, typeInfo);
            }
            else if (value.IsResponseMcpCallCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallCompleted, typeInfo);
            }
            else if (value.IsResponseMcpCallFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseMcpCallFailed, typeInfo);
            }
        }
    }
}