#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionToolChoiceOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ChatCompletionToolChoiceOption>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ChatCompletionToolChoiceOption Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoice? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom? value4 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom).Name}");
                value4 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::tryAGI.OpenAI.ChatCompletionToolChoiceOption(
                value1,
                value2,
                value3,
                value4
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value4 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ChatCompletionToolChoiceOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionToolChoiceOptionEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionAllowedToolsChoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionNamedToolChoice?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoice).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ChatCompletionNamedToolChoiceCustom).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4, typeInfo);
            }
        }
    }
}