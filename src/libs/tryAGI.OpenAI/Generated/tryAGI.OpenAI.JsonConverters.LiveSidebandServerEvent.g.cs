#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class LiveSidebandServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.LiveSidebandServerEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.LiveSidebandServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.LiveTransportRinging? transportRinging = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.TransportRinging)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportRinging), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportRinging> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportRinging)}");
                transportRinging = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportAnswered? transportAnswered = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.TransportAnswered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportAnswered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportAnswered> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportAnswered)}");
                transportAnswered = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportFailed? transportFailed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.TransportFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportFailed)}");
                transportFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportDTMFReceived? transportDtmfReceived = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.TransportDtmfReceived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFReceived> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportDTMFReceived)}");
                transportDtmfReceived = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveTransportDTMFSent? transportDtmfSent = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.TransportDtmfSent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFSent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFSent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveTransportDTMFSent)}");
                transportDtmfSent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionStarted? sessionStarted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionStarted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionStarted)}");
                sessionStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionUpdated? sessionUpdated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionUpdated)}");
                sessionUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioMuted? sessionInputAudioMuted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionInputAudioMuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioMuted)}");
                sessionInputAudioMuted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioUnmuted? sessionInputAudioUnmuted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionInputAudioUnmuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioUnmuted)}");
                sessionInputAudioUnmuted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying? sessionOutputAudioFixturePlaying = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionOutputAudioFixturePlaying)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying)}");
                sessionOutputAudioFixturePlaying = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed? sessionOutputAudioFixturePlayed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionOutputAudioFixturePlayed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed)}");
                sessionOutputAudioFixturePlayed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInstructionsAppended? sessionInstructionsAppended = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionInstructionsAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInstructionsAppended)}");
                sessionInstructionsAppended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveThinkingAppended? sessionThinkingAppended = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionThinkingAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveThinkingAppended)}");
                sessionThinkingAppended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveCommentaryAppended? sessionCommentaryAppended = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionCommentaryAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppended> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveCommentaryAppended)}");
                sessionCommentaryAppended = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputTranscriptDelta? sessionInputTranscriptDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionInputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputTranscriptDelta)}");
                sessionInputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveOutputTranscriptDelta? sessionOutputTranscriptDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionOutputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputTranscriptDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta)}");
                sessionOutputTranscriptDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDelegationCreated? sessionDelegationCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionDelegationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDelegationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDelegationCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDelegationCreated)}");
                sessionDelegationCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionEvent? decisionEvent = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.DecisionEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionEvent)}");
                decisionEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionItemCreated? decisionItemCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.DecisionItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionItemCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionItemCreated)}");
                decisionItemCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionItemDeleted? decisionItemDeleted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.DecisionItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionItemDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionItemDeleted)}");
                decisionItemDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveResponseEvent? responseEvent = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.ResponseEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveResponseEvent)}");
                responseEvent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionUsageUpdated? sessionUsageUpdated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionUsageUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUsageUpdated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionUsageUpdated)}");
                sessionUsageUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionClosed? sessionClosed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.SessionClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionClosed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionClosed)}");
                sessionClosed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveErrorEvent? error = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInfoEvent? info = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandServerEventDiscriminatorType.Info)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInfoEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInfoEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInfoEvent)}");
                info = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.LiveSidebandServerEvent(
                discriminator?.Type,
                transportRinging,

                transportAnswered,

                transportFailed,

                transportDtmfReceived,

                transportDtmfSent,

                sessionStarted,

                sessionUpdated,

                sessionInputAudioMuted,

                sessionInputAudioUnmuted,

                sessionOutputAudioFixturePlaying,

                sessionOutputAudioFixturePlayed,

                sessionInstructionsAppended,

                sessionThinkingAppended,

                sessionCommentaryAppended,

                sessionInputTranscriptDelta,

                sessionOutputTranscriptDelta,

                sessionDelegationCreated,

                decisionEvent,

                decisionItemCreated,

                decisionItemDeleted,

                responseEvent,

                sessionUsageUpdated,

                sessionClosed,

                error,

                info
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.LiveSidebandServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsTransportRinging)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportRinging), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportRinging?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportRinging).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTransportRinging(), typeInfo);
            }
            else if (value.IsTransportAnswered)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportAnswered), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportAnswered?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportAnswered).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTransportAnswered(), typeInfo);
            }
            else if (value.IsTransportFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTransportFailed(), typeInfo);
            }
            else if (value.IsTransportDtmfReceived)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFReceived?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTransportDtmfReceived(), typeInfo);
            }
            else if (value.IsTransportDtmfSent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveTransportDTMFSent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveTransportDTMFSent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveTransportDTMFSent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTransportDtmfSent(), typeInfo);
            }
            else if (value.IsSessionStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionStarted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionStarted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionStarted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionStarted(), typeInfo);
            }
            else if (value.IsSessionUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionUpdated(), typeInfo);
            }
            else if (value.IsSessionInputAudioMuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioMuted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionInputAudioMuted(), typeInfo);
            }
            else if (value.IsSessionInputAudioUnmuted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionInputAudioUnmuted(), typeInfo);
            }
            else if (value.IsSessionOutputAudioFixturePlaying)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlaying).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionOutputAudioFixturePlaying(), typeInfo);
            }
            else if (value.IsSessionOutputAudioFixturePlayed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveOutputAudioFixturePlayed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionOutputAudioFixturePlayed(), typeInfo);
            }
            else if (value.IsSessionInstructionsAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInstructionsAppended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionInstructionsAppended(), typeInfo);
            }
            else if (value.IsSessionThinkingAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveThinkingAppended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionThinkingAppended(), typeInfo);
            }
            else if (value.IsSessionCommentaryAppended)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppended), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppended?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveCommentaryAppended).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionCommentaryAppended(), typeInfo);
            }
            else if (value.IsSessionInputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionInputTranscriptDelta(), typeInfo);
            }
            else if (value.IsSessionOutputTranscriptDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveOutputTranscriptDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveOutputTranscriptDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionOutputTranscriptDelta(), typeInfo);
            }
            else if (value.IsSessionDelegationCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDelegationCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDelegationCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDelegationCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionDelegationCreated(), typeInfo);
            }
            else if (value.IsDecisionEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionEvent(), typeInfo);
            }
            else if (value.IsDecisionItemCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionItemCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionItemCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionItemCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionItemCreated(), typeInfo);
            }
            else if (value.IsDecisionItemDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionItemDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionItemDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionItemDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDecisionItemDeleted(), typeInfo);
            }
            else if (value.IsResponseEvent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveResponseEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseEvent(), typeInfo);
            }
            else if (value.IsSessionUsageUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUsageUpdated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionUsageUpdated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionUsageUpdated(), typeInfo);
            }
            else if (value.IsSessionClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionClosed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionClosed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSessionClosed(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
            else if (value.IsInfo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInfoEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInfoEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInfoEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInfo(), typeInfo);
            }
        }
    }
}