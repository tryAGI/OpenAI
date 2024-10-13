#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.RealtimeServerEvent>
    {
        /// <inheritdoc />
        public override global::OpenAI.RealtimeServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::OpenAI.RealtimeError? error = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeError).Name}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeSessionCreated? sessionCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeSessionCreated).Name}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeSessionUpdated? sessionUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeSessionUpdated).Name}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeConversationCreated? conversationCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationCreated).Name}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeConversationItemCreated? conversationItemCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemCreated).Name}");
                conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted).Name}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed).Name}");
                conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeConversationItemTruncated? conversationItemTruncated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemTruncated).Name}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeConversationItemDeleted? conversationItemDeleted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemDeleted).Name}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferCommitted).Name}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeInputAudioBufferCleared? inputAudioBufferCleared = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferCleared).Name}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted).Name}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped).Name}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseCreated? responseCreated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseCreated).Name}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseDone? responseDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseDone).Name}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseOutputItemAdded? responseOutputItemAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseOutputItemAdded).Name}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseOutputItemDone? responseOutputItemDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseOutputItemDone).Name}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseContentPartAdded? responseContentPartAdded = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseContentPartAdded).Name}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseContentPartDone? responseContentPartDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseContentPartDone).Name}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseTextDelta? responseTextDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseTextDelta).Name}");
                responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseTextDone? responseTextDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseTextDone).Name}");
                responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseAudioTranscriptDelta? responseAudioTranscriptDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta).Name}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseAudioTranscriptDone? responseAudioTranscriptDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone).Name}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseAudioDelta? responseAudioDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioDelta).Name}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseAudioDone? responseAudioDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioDone).Name}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta).Name}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone).Name}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::OpenAI.RealtimeRateLimitsUpdated? rateLimitsUpdated = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeRateLimitsUpdated).Name}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::OpenAI.RealtimeServerEvent(
                error,
                sessionCreated,
                sessionUpdated,
                conversationCreated,
                conversationItemCreated,
                conversationItemInputAudioTranscriptionCompleted,
                conversationItemInputAudioTranscriptionFailed,
                conversationItemTruncated,
                conversationItemDeleted,
                inputAudioBufferCommitted,
                inputAudioBufferCleared,
                inputAudioBufferSpeechStarted,
                inputAudioBufferSpeechStopped,
                responseCreated,
                responseDone,
                responseOutputItemAdded,
                responseOutputItemDone,
                responseContentPartAdded,
                responseContentPartDone,
                responseTextDelta,
                responseTextDone,
                responseAudioTranscriptDelta,
                responseAudioTranscriptDone,
                responseAudioDelta,
                responseAudioDone,
                responseFunctionCallArgumentsDelta,
                responseFunctionCallArgumentsDone,
                rateLimitsUpdated
                );

            if (error != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeError).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeSessionCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (sessionUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeSessionUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionCompleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemInputAudioTranscriptionFailed != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemTruncated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemTruncated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (conversationItemDeleted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemDeleted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCommitted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferCommitted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferCleared != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferCleared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferSpeechStarted != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (inputAudioBufferSpeechStopped != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseCreated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseCreated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputItemAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseOutputItemAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseOutputItemDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseOutputItemDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseContentPartAdded != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseContentPartAdded).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseContentPartDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseContentPartDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseTextDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseTextDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseTextDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseTextDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioTranscriptDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioTranscriptDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseAudioDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseFunctionCallArgumentsDelta != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responseFunctionCallArgumentsDone != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (rateLimitsUpdated != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeRateLimitsUpdated).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.RealtimeServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeInfo);
            }
            else if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemTruncated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemTruncated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeConversationItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCommitted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferCommitted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCleared?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferCleared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStopped?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseOutputItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseOutputItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta, typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseAudioDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeRateLimitsUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RealtimeRateLimitsUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeInfo);
            }
        }
    }
}