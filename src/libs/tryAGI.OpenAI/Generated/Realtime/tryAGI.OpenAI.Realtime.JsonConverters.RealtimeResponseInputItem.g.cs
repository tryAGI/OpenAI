#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class RealtimeResponseInputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.Realtime.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage? message = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall? functionCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput? functionCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType.FunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput)}");
                functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference? itemReference = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItemDiscriminatorType.ItemReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference)}");
                itemReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem(
                discriminator?.Type,
                message,

                functionCall,

                functionCallOutput,

                itemReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.Realtime.RealtimeResponseInputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.Realtime.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessage(), typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCall(), typeInfo);
            }
            else if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseInputFunctionCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCallOutput(), typeInfo);
            }
            else if (value.IsItemReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.Realtime.RealtimeResponseItemReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickItemReference(), typeInfo);
            }
        }
    }
}