#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class RunStepDeltaStepDetailsToolCallJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCall>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCall Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject? callsCodeObject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject).Name}");
                callsCodeObject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject? callsFileSearchObject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject).Name}");
                callsFileSearchObject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject? callsFunctionObject = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject).Name}");
                callsFunctionObject = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCall(
                callsCodeObject,
                callsFileSearchObject,
                callsFunctionObject
                );

            if (callsCodeObject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (callsFileSearchObject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (callsFunctionObject != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCall value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCallsCodeObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsCodeObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallsCodeObject, typeInfo);
            }
            else if (value.IsCallsFileSearchObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFileSearchObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallsFileSearchObject, typeInfo);
            }
            else if (value.IsCallsFunctionObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.RunStepDeltaStepDetailsToolCallsFunctionObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallsFunctionObject, typeInfo);
            }
        }
    }
}