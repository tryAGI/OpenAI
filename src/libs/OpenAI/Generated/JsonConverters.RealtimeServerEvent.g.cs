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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.RealtimeError? error = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeError)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeSessionCreated? sessionCreated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeSessionCreated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeSessionUpdated? sessionUpdated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeSessionUpdated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeConversationCreated? conversationCreated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeConversationCreated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeConversationItemCreated? conversationItemCreated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeConversationItemCreated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted? conversationItemInputAudioTranscriptionCompleted = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionCompleted)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed? conversationItemInputAudioTranscriptionFailed = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeConversationItemInputAudioTranscriptionFailed)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeConversationItemTruncated? conversationItemTruncated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemTruncated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemTruncated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeConversationItemTruncated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeConversationItemDeleted? conversationItemDeleted = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeConversationItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeConversationItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeConversationItemDeleted)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeInputAudioBufferCommitted? inputAudioBufferCommitted = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.InputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCommitted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCommitted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeInputAudioBufferCommitted)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeInputAudioBufferCleared? inputAudioBufferCleared = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.InputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferCleared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferCleared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeInputAudioBufferCleared)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeInputAudioBufferSpeechStarted? inputAudioBufferSpeechStarted = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeInputAudioBufferSpeechStarted)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeInputAudioBufferSpeechStopped? inputAudioBufferSpeechStopped = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.InputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeInputAudioBufferSpeechStopped> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeInputAudioBufferSpeechStopped)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseCreated? responseCreated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseCreated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseDone? responseDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseOutputItemAdded? responseOutputItemAdded = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseOutputItemAdded)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseOutputItemDone? responseOutputItemDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseOutputItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseOutputItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseOutputItemDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseContentPartAdded? responseContentPartAdded = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseContentPartAdded)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseContentPartDone? responseContentPartDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseContentPartDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseTextDelta? responseTextDelta = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseTextDelta)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseTextDone? responseTextDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseTextDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseAudioTranscriptDelta? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseAudioTranscriptDelta)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseAudioTranscriptDone? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioTranscriptDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioTranscriptDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseAudioTranscriptDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseAudioDelta? responseAudioDelta = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseAudioDelta)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseAudioDone? responseAudioDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseAudioDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseAudioDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseAudioDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDelta)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeResponseFunctionCallArgumentsDone? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeResponseFunctionCallArgumentsDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeResponseFunctionCallArgumentsDone)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RealtimeRateLimitsUpdated? rateLimitsUpdated = default;
            if (discriminator?.Type == global::OpenAI.RealtimeServerEventDiscriminatorType.RateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RealtimeRateLimitsUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RealtimeRateLimitsUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RealtimeRateLimitsUpdated)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.RealtimeServerEvent(
                discriminator?.Type,
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