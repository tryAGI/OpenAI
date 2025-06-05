#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.OutputItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.OutputItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::tryAGI.OpenAI.OutputMessage? message = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.OutputMessage).Name}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.FileSearchToolCall? fileSearchToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FileSearchToolCall).Name}");
                fileSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.FunctionToolCall? functionToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionToolCall).Name}");
                functionToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.WebSearchToolCall? webSearchToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchToolCall).Name}");
                webSearchToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ComputerToolCall? computerToolCall = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerToolCall).Name}");
                computerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::tryAGI.OpenAI.ReasoningItem? reasoning = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItem).Name}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::tryAGI.OpenAI.OutputItem(
                message,
                fileSearchToolCall,
                functionToolCall,
                webSearchToolCall,
                computerToolCall,
                reasoning
                );

            if (message != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.OutputMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.OutputMessage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (fileSearchToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FileSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FileSearchToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (functionToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (webSearchToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (computerToolCall != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerToolCall).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (reasoning != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItem).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.OutputItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message, typeInfo);
            }
            else if (value.IsFileSearchToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FileSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FileSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FileSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchToolCall, typeInfo);
            }
            else if (value.IsFunctionToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.FunctionToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.FunctionToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.FunctionToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionToolCall, typeInfo);
            }
            else if (value.IsWebSearchToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WebSearchToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WebSearchToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WebSearchToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolCall, typeInfo);
            }
            else if (value.IsComputerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ComputerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ComputerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ComputerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerToolCall, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning, typeInfo);
            }
        }
    }
}