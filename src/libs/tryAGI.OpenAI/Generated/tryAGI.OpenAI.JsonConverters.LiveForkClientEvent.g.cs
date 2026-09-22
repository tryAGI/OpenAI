#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class LiveForkClientEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.LiveForkClientEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.LiveForkClientEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveForkClientEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveForkClientEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveForkClientEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.LiveForkSessionStartEvent? sessionStart = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveForkSessionStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveForkSessionStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveForkSessionStartEvent)}");
                sessionStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionUpdateParam? sessionUpdate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdateParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionUpdateParam)}");
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioAppendEvent? sessionInputAudioAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionInputAudioAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioAppendEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioAppendEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioAppendEvent)}");
                sessionInputAudioAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioMuteParam? sessionInputAudioMute = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionInputAudioMute)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuteParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuteParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioMuteParam)}");
                sessionInputAudioMute = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? sessionInputAudioUnmute = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionInputAudioUnmute)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam)}");
                sessionInputAudioUnmute = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInstructionsAppendParam? sessionInstructionsAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionInstructionsAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppendParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInstructionsAppendParam)}");
                sessionInstructionsAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveThinkingAppendParam? sessionThinkingAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionThinkingAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppendParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveThinkingAppendParam)}");
                sessionThinkingAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveCommentaryAppendParam? sessionCommentaryAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionCommentaryAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppendParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveCommentaryAppendParam)}");
                sessionCommentaryAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveResponseItemCreateParam? responseItemCreate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.ResponseItemCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseItemCreateParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveResponseItemCreateParam)}");
                responseItemCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveResponseCreateParam? responseCreate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.ResponseCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseCreateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseCreateParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveResponseCreateParam)}");
                responseCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionCloseParam? sessionClose = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveForkClientEventDiscriminatorType.SessionClose)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionCloseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionCloseParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionCloseParam)}");
                sessionClose = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.LiveForkClientEvent(
                discriminator?.Type,
                sessionStart,

                sessionUpdate,

                sessionInputAudioAppend,

                sessionInputAudioMute,

                sessionInputAudioUnmute,

                sessionInstructionsAppend,

                sessionThinkingAppend,

                sessionCommentaryAppend,

                responseItemCreate,

                responseCreate,

                sessionClose
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.LiveForkClientEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveForkSessionStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveForkSessionStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveForkSessionStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionStart!, typeInfo);
            }
            else if (value.IsSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdateParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate!, typeInfo);
            }
            else if (value.IsSessionInputAudioAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioAppendEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioAppendEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioAppendEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioAppend!, typeInfo);
            }
            else if (value.IsSessionInputAudioMute)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuteParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuteParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioMuteParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioMute!, typeInfo);
            }
            else if (value.IsSessionInputAudioUnmute)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInputAudioUnmute!, typeInfo);
            }
            else if (value.IsSessionInstructionsAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppendParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveInstructionsAppendParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionInstructionsAppend!, typeInfo);
            }
            else if (value.IsSessionThinkingAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppendParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveThinkingAppendParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionThinkingAppend!, typeInfo);
            }
            else if (value.IsSessionCommentaryAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppendParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveCommentaryAppendParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionCommentaryAppend!, typeInfo);
            }
            else if (value.IsResponseItemCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseItemCreateParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseItemCreate!, typeInfo);
            }
            else if (value.IsResponseCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseCreateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseCreateParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveResponseCreateParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreate!, typeInfo);
            }
            else if (value.IsSessionClose)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionCloseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionCloseParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionCloseParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionClose!, typeInfo);
            }
        }
    }
}