#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class SessionEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.SessionEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.SessionEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.SessionEventError? error = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventError)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady? agentSessionEnvironmentReady = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionEnvironmentReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady)}");
                agentSessionEnvironmentReady = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset? agentSessionEnvironmentReset = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionEnvironmentReset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset)}");
                agentSessionEnvironmentReset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta? agentOutputCommandExecutionOutputDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentOutputCommandExecutionOutputDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta)}");
                agentOutputCommandExecutionOutputDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionCreated? agentSessionCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionCreated)}");
                agentSessionCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated? agentSessionTurnCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated)}");
                agentSessionTurnCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress? agentSessionTurnInProgress = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress)}");
                agentSessionTurnInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted? agentSessionTurnCompleted = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted)}");
                agentSessionTurnCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed? agentSessionTurnFailed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed)}");
                agentSessionTurnFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled? agentSessionTurnCancelled = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled)}");
                agentSessionTurnCancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded? agentSessionTurnItemAdded = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded)}");
                agentSessionTurnItemAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionIdle? agentSessionIdle = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionIdle> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionIdle)}");
                agentSessionIdle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionInProgress? agentSessionInProgress = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionInProgress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress)}");
                agentSessionInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction? agentSessionRequiresAction = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction)}");
                agentSessionRequiresAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionFailed? agentSessionFailed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionFailed)}");
                agentSessionFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending? agentSessionEnvironmentPending = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionEnvironmentPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending)}");
                agentSessionEnvironmentPending = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected? agentSessionEnvironmentConnected = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionEnvironmentConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected)}");
                agentSessionEnvironmentConnected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected? agentSessionEnvironmentDisconnected = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionEnvironmentDisconnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected)}");
                agentSessionEnvironmentDisconnected = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed? agentSessionEnvironmentFailed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionEnvironmentFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed)}");
                agentSessionEnvironmentFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated? agentSessionSubagentCreated = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionSubagentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated)}");
                agentSessionSubagentCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive? agentSessionSubagentActive = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionSubagentActive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive)}");
                agentSessionSubagentActive = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed? agentSessionSubagentClosed = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionSubagentClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed)}");
                agentSessionSubagentClosed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone? agentSessionTurnItemDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone)}");
                agentSessionTurnItemDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded? agentSessionTurnContentPartAdded = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded)}");
                agentSessionTurnContentPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone? agentSessionTurnContentPartDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone)}");
                agentSessionTurnContentPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta? agentSessionTurnOutputTextDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta)}");
                agentSessionTurnOutputTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone? agentSessionTurnOutputTextDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone)}");
                agentSessionTurnOutputTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded? agentSessionTurnReasoningSummaryPartAdded = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded)}");
                agentSessionTurnReasoningSummaryPartAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone? agentSessionTurnReasoningSummaryPartDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone)}");
                agentSessionTurnReasoningSummaryPartDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta? agentSessionTurnReasoningSummaryTextDelta = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta)}");
                agentSessionTurnReasoningSummaryTextDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone? agentSessionTurnReasoningSummaryTextDone = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.SessionEventDiscriminatorType.AgentSessionTurnReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone)}");
                agentSessionTurnReasoningSummaryTextDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.SessionEvent(
                discriminator?.Type,
                error,

                agentSessionEnvironmentReady,

                agentSessionEnvironmentReset,

                agentOutputCommandExecutionOutputDelta,

                agentSessionCreated,

                agentSessionTurnCreated,

                agentSessionTurnInProgress,

                agentSessionTurnCompleted,

                agentSessionTurnFailed,

                agentSessionTurnCancelled,

                agentSessionTurnItemAdded,

                agentSessionIdle,

                agentSessionInProgress,

                agentSessionRequiresAction,

                agentSessionFailed,

                agentSessionEnvironmentPending,

                agentSessionEnvironmentConnected,

                agentSessionEnvironmentDisconnected,

                agentSessionEnvironmentFailed,

                agentSessionSubagentCreated,

                agentSessionSubagentActive,

                agentSessionSubagentClosed,

                agentSessionTurnItemDone,

                agentSessionTurnContentPartAdded,

                agentSessionTurnContentPartDone,

                agentSessionTurnOutputTextDelta,

                agentSessionTurnOutputTextDone,

                agentSessionTurnReasoningSummaryPartAdded,

                agentSessionTurnReasoningSummaryPartDone,

                agentSessionTurnReasoningSummaryTextDelta,

                agentSessionTurnReasoningSummaryTextDone
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.SessionEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
            else if (value.IsAgentSessionEnvironmentReady)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReady).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionEnvironmentReady!, typeInfo);
            }
            else if (value.IsAgentSessionEnvironmentReset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentReset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionEnvironmentReset!, typeInfo);
            }
            else if (value.IsAgentOutputCommandExecutionOutputDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentOutputCommandExecutionOutputDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentOutputCommandExecutionOutputDelta!, typeInfo);
            }
            else if (value.IsAgentSessionCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionCreated!, typeInfo);
            }
            else if (value.IsAgentSessionTurnCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnCreated!, typeInfo);
            }
            else if (value.IsAgentSessionTurnInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnInProgress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnInProgress!, typeInfo);
            }
            else if (value.IsAgentSessionTurnCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnCompleted!, typeInfo);
            }
            else if (value.IsAgentSessionTurnFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnFailed!, typeInfo);
            }
            else if (value.IsAgentSessionTurnCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnCancelled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnCancelled!, typeInfo);
            }
            else if (value.IsAgentSessionTurnItemAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnItemAdded!, typeInfo);
            }
            else if (value.IsAgentSessionIdle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdle), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionIdle?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionIdle).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionIdle!, typeInfo);
            }
            else if (value.IsAgentSessionInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionInProgress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionInProgress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionInProgress!, typeInfo);
            }
            else if (value.IsAgentSessionRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionRequiresAction).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionRequiresAction!, typeInfo);
            }
            else if (value.IsAgentSessionFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionFailed!, typeInfo);
            }
            else if (value.IsAgentSessionEnvironmentPending)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentPending).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionEnvironmentPending!, typeInfo);
            }
            else if (value.IsAgentSessionEnvironmentConnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentConnected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionEnvironmentConnected!, typeInfo);
            }
            else if (value.IsAgentSessionEnvironmentDisconnected)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentDisconnected).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionEnvironmentDisconnected!, typeInfo);
            }
            else if (value.IsAgentSessionEnvironmentFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionEnvironmentFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionEnvironmentFailed!, typeInfo);
            }
            else if (value.IsAgentSessionSubagentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentCreated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionSubagentCreated!, typeInfo);
            }
            else if (value.IsAgentSessionSubagentActive)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentActive).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionSubagentActive!, typeInfo);
            }
            else if (value.IsAgentSessionSubagentClosed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionSubagentClosed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionSubagentClosed!, typeInfo);
            }
            else if (value.IsAgentSessionTurnItemDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnItemDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnItemDone!, typeInfo);
            }
            else if (value.IsAgentSessionTurnContentPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnContentPartAdded!, typeInfo);
            }
            else if (value.IsAgentSessionTurnContentPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnContentPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnContentPartDone!, typeInfo);
            }
            else if (value.IsAgentSessionTurnOutputTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnOutputTextDelta!, typeInfo);
            }
            else if (value.IsAgentSessionTurnOutputTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnOutputTextDone!, typeInfo);
            }
            else if (value.IsAgentSessionTurnReasoningSummaryPartAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartAdded).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnReasoningSummaryPartAdded!, typeInfo);
            }
            else if (value.IsAgentSessionTurnReasoningSummaryPartDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryPartDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnReasoningSummaryPartDone!, typeInfo);
            }
            else if (value.IsAgentSessionTurnReasoningSummaryTextDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDelta).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnReasoningSummaryTextDelta!, typeInfo);
            }
            else if (value.IsAgentSessionTurnReasoningSummaryTextDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.SessionEventAgentSessionTurnReasoningSummaryTextDone).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentSessionTurnReasoningSummaryTextDone!, typeInfo);
            }
        }
    }
}