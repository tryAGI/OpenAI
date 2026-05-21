#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeClientEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeClientEvent>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Realtime.RealtimeClientEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate? conversationItemCreate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.ConversationItemCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate)}");
                conversationItemCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete? conversationItemDelete = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.ConversationItemDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete)}");
                conversationItemDelete = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve? conversationItemRetrieve = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.ConversationItemRetrieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve)}");
                conversationItemRetrieve = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate? conversationItemTruncate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.ConversationItemTruncate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate)}");
                conversationItemTruncate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend? inputAudioBufferAppend = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.InputAudioBufferAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend)}");
                inputAudioBufferAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear? inputAudioBufferClear = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.InputAudioBufferClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear)}");
                inputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear? outputAudioBufferClear = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.OutputAudioBufferClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear)}");
                outputAudioBufferClear = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit? inputAudioBufferCommit = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.InputAudioBufferCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit)}");
                inputAudioBufferCommit = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel? responseCancel = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.ResponseCancel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel)}");
                responseCancel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate? responseCreate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.ResponseCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate)}");
                responseCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate? sessionUpdate = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeClientEventDiscriminatorType.SessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate)}");
                sessionUpdate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Realtime.RealtimeClientEvent(
                discriminator?.Type,
                conversationItemCreate,

                conversationItemDelete,

                conversationItemRetrieve,

                conversationItemTruncate,

                inputAudioBufferAppend,

                inputAudioBufferClear,

                outputAudioBufferClear,

                inputAudioBufferCommit,

                responseCancel,

                responseCreate,

                sessionUpdate
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Realtime.RealtimeClientEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsConversationItemCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemCreate!, typeInfo);
            }
            else if (value.IsConversationItemDelete)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemDelete).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemDelete!, typeInfo);
            }
            else if (value.IsConversationItemRetrieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemRetrieve).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemRetrieve!, typeInfo);
            }
            else if (value.IsConversationItemTruncate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventConversationItemTruncate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConversationItemTruncate!, typeInfo);
            }
            else if (value.IsInputAudioBufferAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferAppend).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferAppend!, typeInfo);
            }
            else if (value.IsInputAudioBufferClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferClear).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferClear!, typeInfo);
            }
            else if (value.IsOutputAudioBufferClear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventOutputAudioBufferClear).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAudioBufferClear!, typeInfo);
            }
            else if (value.IsInputAudioBufferCommit)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventInputAudioBufferCommit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudioBufferCommit!, typeInfo);
            }
            else if (value.IsResponseCancel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCancel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCancel!, typeInfo);
            }
            else if (value.IsResponseCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventResponseCreate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseCreate!, typeInfo);
            }
            else if (value.IsSessionUpdate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeClientEventSessionUpdate).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SessionUpdate!, typeInfo);
            }
        }
    }
}