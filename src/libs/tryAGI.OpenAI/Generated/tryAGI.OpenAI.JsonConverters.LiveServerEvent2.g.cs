#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class LiveServerEvent2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.LiveServerEvent2>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.LiveServerEvent2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveServerEvent2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveServerEvent2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveServerEvent2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.LiveSessionStarted? sessionStarted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionStarted)}");
                sessionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionUpdated? sessionUpdated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionUpdated)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioMuted? sessionInputAudioMuted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionInputAudioMuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioMuted)}");
                sessionInputAudioMuted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioUnmuted? sessionInputAudioUnmuted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionInputAudioUnmuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioUnmuted)}");
                sessionInputAudioUnmuted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInstructionsAppended? sessionInstructionsAppended = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionInstructionsAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInstructionsAppended)}");
                sessionInstructionsAppended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveThinkingAppended? sessionThinkingAppended = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionThinkingAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveThinkingAppended)}");
                sessionThinkingAppended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveCommentaryAppended? sessionCommentaryAppended = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionCommentaryAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveCommentaryAppended)}");
                sessionCommentaryAppended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioAppend? sessionInputAudioAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionInputAudioAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioAppend)}");
                sessionInputAudioAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveOutputAudioDelta? sessionOutputAudioDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputAudioDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveOutputAudioDelta)}");
                sessionOutputAudioDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputTranscriptDelta? sessionInputTranscriptDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionInputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputTranscriptDelta)}");
                sessionInputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveOutputTranscriptDelta? sessionOutputTranscriptDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionOutputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta)}");
                sessionOutputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDelegationCreated? sessionDelegationCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionDelegationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDelegationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDelegationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDelegationCreated)}");
                sessionDelegationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveResponseEvent? responseEvent = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.ResponseEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveResponseEvent)}");
                responseEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionUsageUpdated? sessionUsageUpdated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionUsageUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUsageUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionUsageUpdated)}");
                sessionUsageUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionClosed? sessionClosed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.SessionClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionClosed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionClosed)}");
                sessionClosed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveErrorEvent? error = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInfoEvent? info = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.Info)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInfoEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInfoEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInfoEvent)}");
                info = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportDTMFReceived? transportDtmfReceived = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.TransportDtmfReceived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFReceived> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportDTMFReceived)}");
                transportDtmfReceived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportDTMFSend? transportDtmfSend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.TransportDtmfSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFSend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFSend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportDTMFSend)}");
                transportDtmfSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportRinging? transportRinging = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.TransportRinging)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportRinging), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportRinging> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportRinging)}");
                transportRinging = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportAnswered? transportAnswered = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.TransportAnswered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportAnswered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportAnswered> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportAnswered)}");
                transportAnswered = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportFailed? transportFailed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType.TransportFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportFailed)}");
                transportFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.LiveServerEvent2(
                discriminator?.Type,
                sessionStarted,

                sessionUpdated,

                sessionInputAudioMuted,

                sessionInputAudioUnmuted,

                sessionInstructionsAppended,

                sessionThinkingAppended,

                sessionCommentaryAppended,

                sessionInputAudioAppend,

                sessionOutputAudioDelta,

                sessionInputTranscriptDelta,

                sessionOutputTranscriptDelta,

                sessionDelegationCreated,

                responseEvent,

                sessionUsageUpdated,

                sessionClosed,

                error,

                info,

                transportDtmfReceived,

                transportDtmfSend,

                transportRinging,

                transportAnswered,

                transportFailed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.LiveServerEvent2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStarted!, typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdated!, typeInfo);
            }
            else if (value.IsSessionInputAudioMuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioMuted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioMuted!, typeInfo);
            }
            else if (value.IsSessionInputAudioUnmuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioUnmuted!, typeInfo);
            }
            else if (value.IsSessionInstructionsAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInstructionsAppended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInstructionsAppended!, typeInfo);
            }
            else if (value.IsSessionThinkingAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveThinkingAppended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionThinkingAppended!, typeInfo);
            }
            else if (value.IsSessionCommentaryAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveCommentaryAppended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCommentaryAppended!, typeInfo);
            }
            else if (value.IsSessionInputAudioAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioAppend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioAppend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioAppend!, typeInfo);
            }
            else if (value.IsSessionOutputAudioDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputAudioDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputAudioDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveOutputAudioDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionOutputAudioDelta!, typeInfo);
            }
            else if (value.IsSessionInputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputTranscriptDelta!, typeInfo);
            }
            else if (value.IsSessionOutputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionOutputTranscriptDelta!, typeInfo);
            }
            else if (value.IsSessionDelegationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDelegationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDelegationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDelegationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionDelegationCreated!, typeInfo);
            }
            else if (value.IsResponseEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveResponseEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseEvent!, typeInfo);
            }
            else if (value.IsSessionUsageUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUsageUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUsageUpdated!, typeInfo);
            }
            else if (value.IsSessionClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionClosed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionClosed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionClosed!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInfoEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInfoEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInfoEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Info!, typeInfo);
            }
            else if (value.IsTransportDtmfReceived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFReceived?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransportDtmfReceived!, typeInfo);
            }
            else if (value.IsTransportDtmfSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFSend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFSend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportDTMFSend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransportDtmfSend!, typeInfo);
            }
            else if (value.IsTransportRinging)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportRinging), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportRinging?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportRinging).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransportRinging!, typeInfo);
            }
            else if (value.IsTransportAnswered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportAnswered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportAnswered?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportAnswered).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransportAnswered!, typeInfo);
            }
            else if (value.IsTransportFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransportFailed!, typeInfo);
            }
        }
    }
}