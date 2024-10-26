#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class AssistantStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.AssistantStreamEvent>
    {
        /// <inheritdoc />
        public override global::OpenAI.AssistantStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.ErrorEvent? error = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.ErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.DoneEvent? done = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.Done)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.DoneEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.DoneEvent)}");
                done = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant3? threadCreated = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant3)}");
                threadCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant4? threadRunCreated = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant4)}");
                threadRunCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant5? threadRunQueued = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant5)}");
                threadRunQueued = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant6? threadRunInProgress = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant6)}");
                threadRunInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant7? threadRunRequiresAction = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant7)}");
                threadRunRequiresAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant8? threadRunCompleted = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant8)}");
                threadRunCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant9? threadRunIncomplete = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant9)}");
                threadRunIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant10? threadRunFailed = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant10)}");
                threadRunFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant11? threadRunCancelling = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCancelling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant11)}");
                threadRunCancelling = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant12? threadRunCancelled = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant12)}");
                threadRunCancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant13? threadRunExpired = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant13)}");
                threadRunExpired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant14? threadRunStepCreated = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant14)}");
                threadRunStepCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant15? threadRunStepInProgress = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant15)}");
                threadRunStepInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant16? threadRunStepDelta = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant16)}");
                threadRunStepDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant17? threadRunStepCompleted = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant17)}");
                threadRunStepCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant18? threadRunStepFailed = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant18)}");
                threadRunStepFailed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant19? threadRunStepCancelled = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant19)}");
                threadRunStepCancelled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant20? threadRunStepExpired = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadRunStepExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant20)}");
                threadRunStepExpired = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant21? threadMessageCreated = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant21)}");
                threadMessageCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant22? threadMessageInProgress = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant22)}");
                threadMessageInProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant23? threadMessageDelta = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant23)}");
                threadMessageDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant24? threadMessageCompleted = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant24> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant24)}");
                threadMessageCompleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.AssistantStreamEventVariant25? threadMessageIncomplete = default;
            if (discriminator?.Event == global::OpenAI.AssistantStreamEventDiscriminatorEvent.ThreadMessageIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant25> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.AssistantStreamEventVariant25)}");
                threadMessageIncomplete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.AssistantStreamEvent(
                discriminator?.Event,
                error,
                done,
                threadCreated,
                threadRunCreated,
                threadRunQueued,
                threadRunInProgress,
                threadRunRequiresAction,
                threadRunCompleted,
                threadRunIncomplete,
                threadRunFailed,
                threadRunCancelling,
                threadRunCancelled,
                threadRunExpired,
                threadRunStepCreated,
                threadRunStepInProgress,
                threadRunStepDelta,
                threadRunStepCompleted,
                threadRunStepFailed,
                threadRunStepCancelled,
                threadRunStepExpired,
                threadMessageCreated,
                threadMessageInProgress,
                threadMessageDelta,
                threadMessageCompleted,
                threadMessageIncomplete
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.AssistantStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.ErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.ErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.ErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error, typeInfo);
            }
            else if (value.IsDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.DoneEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.DoneEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.DoneEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Done, typeInfo);
            }
            else if (value.IsThreadCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadCreated, typeInfo);
            }
            else if (value.IsThreadRunCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCreated, typeInfo);
            }
            else if (value.IsThreadRunQueued)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunQueued, typeInfo);
            }
            else if (value.IsThreadRunInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunInProgress, typeInfo);
            }
            else if (value.IsThreadRunRequiresAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunRequiresAction, typeInfo);
            }
            else if (value.IsThreadRunCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCompleted, typeInfo);
            }
            else if (value.IsThreadRunIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunIncomplete, typeInfo);
            }
            else if (value.IsThreadRunFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunFailed, typeInfo);
            }
            else if (value.IsThreadRunCancelling)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCancelling, typeInfo);
            }
            else if (value.IsThreadRunCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunCancelled, typeInfo);
            }
            else if (value.IsThreadRunExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunExpired, typeInfo);
            }
            else if (value.IsThreadRunStepCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepCreated, typeInfo);
            }
            else if (value.IsThreadRunStepInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepInProgress, typeInfo);
            }
            else if (value.IsThreadRunStepDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepDelta, typeInfo);
            }
            else if (value.IsThreadRunStepCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepCompleted, typeInfo);
            }
            else if (value.IsThreadRunStepFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepFailed, typeInfo);
            }
            else if (value.IsThreadRunStepCancelled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepCancelled, typeInfo);
            }
            else if (value.IsThreadRunStepExpired)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadRunStepExpired, typeInfo);
            }
            else if (value.IsThreadMessageCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageCreated, typeInfo);
            }
            else if (value.IsThreadMessageInProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant22?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageInProgress, typeInfo);
            }
            else if (value.IsThreadMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant23?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageDelta, typeInfo);
            }
            else if (value.IsThreadMessageCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant24), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant24?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant24).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageCompleted, typeInfo);
            }
            else if (value.IsThreadMessageIncomplete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.AssistantStreamEventVariant25), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.AssistantStreamEventVariant25?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.AssistantStreamEventVariant25).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ThreadMessageIncomplete, typeInfo);
            }
        }
    }
}