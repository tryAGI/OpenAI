#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.Realtime.ErrorPayload? error = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ErrorPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ErrorPayload)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.SessionCreatedPayload? sessionCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.SessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.SessionCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload)}");
                sessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload? sessionUpdated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload? conversationCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload)}");
                conversationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload? conversationItemCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload)}");
                conversationItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload? conversationItemInputAudioTranscriptionCompleted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload)}");
                conversationItemInputAudioTranscriptionCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload? conversationItemInputAudioTranscriptionFailed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload)}");
                conversationItemInputAudioTranscriptionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload? conversationItemTruncated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload)}");
                conversationItemTruncated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload? conversationItemDeleted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload)}");
                conversationItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload? inputAudioBufferCommitted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.InputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload)}");
                inputAudioBufferCommitted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload? inputAudioBufferCleared = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.InputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload)}");
                inputAudioBufferCleared = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload? inputAudioBufferSpeechStarted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.InputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload)}");
                inputAudioBufferSpeechStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload? inputAudioBufferSpeechStopped = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.InputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload)}");
                inputAudioBufferSpeechStopped = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload? responseCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload)}");
                responseCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseDonePayload? responseDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseDonePayload)}");
                responseDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload? responseOutputItemAdded = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload)}");
                responseOutputItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload? responseOutputItemDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload)}");
                responseOutputItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload? responseContentPartAdded = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload)}");
                responseContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload? responseContentPartDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload)}");
                responseContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload? responseTextDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload)}");
                responseTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload? responseTextDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload)}");
                responseTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload? responseAudioTranscriptDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload)}");
                responseAudioTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload? responseAudioTranscriptDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload)}");
                responseAudioTranscriptDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload? responseAudioDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload)}");
                responseAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload? responseAudioDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload)}");
                responseAudioDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload? responseFunctionCallArgumentsDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload)}");
                responseFunctionCallArgumentsDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload? responseFunctionCallArgumentsDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.ResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload)}");
                responseFunctionCallArgumentsDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload? rateLimitsUpdated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.ServerEventDiscriminatorType.RateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload)}");
                rateLimitsUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Realtime.ServerEvent(
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

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ErrorPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ErrorPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ErrorPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.SessionCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.SessionCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCreated, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.SessionUpdatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated, typeInfo);
            }
            else if (value.IsConversationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ConversationCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationCreated, typeInfo);
            }
            else if (value.IsConversationItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ConversationItemCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreated, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionCompletedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionCompleted, typeInfo);
            }
            else if (value.IsConversationItemInputAudioTranscriptionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ConversationItemInputAudioTranscriptionFailedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemInputAudioTranscriptionFailed, typeInfo);
            }
            else if (value.IsConversationItemTruncated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ConversationItemTruncatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncated, typeInfo);
            }
            else if (value.IsConversationItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ConversationItemDeletedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDeleted, typeInfo);
            }
            else if (value.IsInputAudioBufferCommitted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferCommittedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommitted, typeInfo);
            }
            else if (value.IsInputAudioBufferCleared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferClearedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCleared, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStartedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStarted, typeInfo);
            }
            else if (value.IsInputAudioBufferSpeechStopped)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.InputAudioBufferSpeechStoppedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferSpeechStopped, typeInfo);
            }
            else if (value.IsResponseCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseCreatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreated, typeInfo);
            }
            else if (value.IsResponseDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseDone, typeInfo);
            }
            else if (value.IsResponseOutputItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemAddedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemAdded, typeInfo);
            }
            else if (value.IsResponseOutputItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseOutputItemDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseOutputItemDone, typeInfo);
            }
            else if (value.IsResponseContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartAddedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartAdded, typeInfo);
            }
            else if (value.IsResponseContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseContentPartDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseContentPartDone, typeInfo);
            }
            else if (value.IsResponseTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDelta, typeInfo);
            }
            else if (value.IsResponseTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseTextDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseTextDone, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDelta, typeInfo);
            }
            else if (value.IsResponseAudioTranscriptDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioTranscriptDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioTranscriptDone, typeInfo);
            }
            else if (value.IsResponseAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDelta, typeInfo);
            }
            else if (value.IsResponseAudioDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseAudioDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseAudioDone, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDeltaPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDelta, typeInfo);
            }
            else if (value.IsResponseFunctionCallArgumentsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.ResponseFunctionCallArgumentsDonePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseFunctionCallArgumentsDone, typeInfo);
            }
            else if (value.IsRateLimitsUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RateLimitsUpdatedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsUpdated, typeInfo);
            }
        }
    }
}