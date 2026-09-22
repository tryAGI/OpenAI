#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class LiveSidebandClientEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.LiveSidebandClientEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.LiveSidebandClientEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.LiveSessionUpdateParam? sessionUpdate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdateParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionUpdateParam)}");
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioMuteParam? sessionInputAudioMute = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionInputAudioMute)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioMuteParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioMuteParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioMuteParam)}");
                sessionInputAudioMute = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInputAudioUnmuteParam? sessionInputAudioUnmute = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionInputAudioUnmute)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInputAudioUnmuteParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInputAudioUnmuteParam)}");
                sessionInputAudioUnmute = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveInstructionsAppendParam? sessionInstructionsAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionInstructionsAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveInstructionsAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveInstructionsAppendParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveInstructionsAppendParam)}");
                sessionInstructionsAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveThinkingAppendParam? sessionThinkingAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionThinkingAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveThinkingAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveThinkingAppendParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveThinkingAppendParam)}");
                sessionThinkingAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveCommentaryAppendParam? sessionCommentaryAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionCommentaryAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveCommentaryAppendParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveCommentaryAppendParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveCommentaryAppendParam)}");
                sessionCommentaryAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveResponseItemCreateParam? responseItemCreate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.ResponseItemCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseItemCreateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseItemCreateParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveResponseItemCreateParam)}");
                responseItemCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveResponseCreateParam? responseCreate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.ResponseCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveResponseCreateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveResponseCreateParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveResponseCreateParam)}");
                responseCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveSessionCloseParam? sessionClose = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveSidebandClientEventDiscriminatorType.SessionClose)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionCloseParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionCloseParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveSessionCloseParam)}");
                sessionClose = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.LiveSidebandClientEvent(
                discriminator?.Type,
                sessionUpdate,

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
            global::tryAGI.OpenAI.LiveSidebandClientEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveSessionUpdateParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveSessionUpdateParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate!, typeInfo);
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