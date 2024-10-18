#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ToolCallsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenAI.ToolCallsItem2>
    {
        /// <inheritdoc />
        public override global::OpenAI.ToolCallsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenAI.RunStepDetailsToolCallsCodeObject? runStepDetailsCodeObject = default;
            if (discriminator?.Type == global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsCodeObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RunStepDetailsToolCallsFileSearchObject? runStepDetailsFileSearchObject = default;
            if (discriminator?.Type == global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsFileSearchObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsFileSearchObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenAI.RunStepDetailsToolCallsFunctionObject? runStepDetailsFunctionObject = default;
            if (discriminator?.Type == global::OpenAI.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsFunctionObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenAI.RunStepDetailsToolCallsFunctionObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::OpenAI.ToolCallsItem2(
                discriminator?.Type,
                runStepDetailsCodeObject,
                runStepDetailsFileSearchObject,
                runStepDetailsFunctionObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenAI.ToolCallsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunStepDetailsCodeObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsCodeObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsToolCallsCodeObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepDetailsCodeObject, typeInfo);
            }
            else if (value.IsRunStepDetailsFileSearchObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsFileSearchObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsToolCallsFileSearchObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepDetailsFileSearchObject, typeInfo);
            }
            else if (value.IsRunStepDetailsFunctionObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenAI.RunStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenAI.RunStepDetailsToolCallsFunctionObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenAI.RunStepDetailsToolCallsFunctionObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepDetailsFunctionObject, typeInfo);
            }
        }
    }
}