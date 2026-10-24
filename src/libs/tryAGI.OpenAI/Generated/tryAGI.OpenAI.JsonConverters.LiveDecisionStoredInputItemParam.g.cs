#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class LiveDecisionStoredInputItemParamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1? message = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam? functionCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam? functionCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType.FunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam)}");
                functionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam? customToolCall = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType.CustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam)}");
                customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam? customToolCallOutput = default;
            if (discriminator?.Type == global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamDiscriminatorType.CustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam)}");
                customToolCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam(
                discriminator?.Type,
                message,

                functionCall,

                functionCallOutput,

                customToolCall,

                customToolCallOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.LiveDecisionStoredInputItemParam value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::tryAGI.OpenAI.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionStoredInputItemParamVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessage(), typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCall(), typeInfo);
            }
            else if (value.IsFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionStoredFunctionCallOutputParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCallOutput(), typeInfo);
            }
            else if (value.IsCustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustomToolCall(), typeInfo);
            }
            else if (value.IsCustomToolCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.LiveDecisionStoredCustomToolCallOutputParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustomToolCallOutput(), typeInfo);
            }
        }
    }
}