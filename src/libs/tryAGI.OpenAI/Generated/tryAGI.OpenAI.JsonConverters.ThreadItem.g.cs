#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace tryAGI.OpenAI.JsonConverters
{
    /// <inheritdoc />
    public class ThreadItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::tryAGI.OpenAI.ThreadItem>
    {
        /// <inheritdoc />
        public override global::tryAGI.OpenAI.ThreadItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("object")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("thread_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("attachments")) __score0++;
            if (__jsonProps.Contains("inference_options")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("object")) __score1++;
            if (__jsonProps.Contains("created_at")) __score1++;
            if (__jsonProps.Contains("thread_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("content")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("object")) __score2++;
            if (__jsonProps.Contains("created_at")) __score2++;
            if (__jsonProps.Contains("thread_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("widget")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("object")) __score3++;
            if (__jsonProps.Contains("created_at")) __score3++;
            if (__jsonProps.Contains("thread_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("arguments")) __score3++;
            if (__jsonProps.Contains("output")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("object")) __score4++;
            if (__jsonProps.Contains("created_at")) __score4++;
            if (__jsonProps.Contains("thread_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("task_type")) __score4++;
            if (__jsonProps.Contains("heading")) __score4++;
            if (__jsonProps.Contains("summary")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("object")) __score5++;
            if (__jsonProps.Contains("created_at")) __score5++;
            if (__jsonProps.Contains("thread_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("tasks")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::tryAGI.OpenAI.UserMessageItem? chatkitUserMessage = default;
            global::tryAGI.OpenAI.AssistantMessageItem? chatkitAssistantMessage = default;
            global::tryAGI.OpenAI.WidgetMessageItem? chatkitWidget = default;
            global::tryAGI.OpenAI.ClientToolCallItem? chatkitClientToolCall = default;
            global::tryAGI.OpenAI.TaskItem? chatkitTask = default;
            global::tryAGI.OpenAI.TaskGroupItem? chatkitTaskGroup = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageItem).Name}");
                        chatkitUserMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AssistantMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AssistantMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AssistantMessageItem).Name}");
                        chatkitAssistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WidgetMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WidgetMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WidgetMessageItem).Name}");
                        chatkitWidget = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ClientToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ClientToolCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ClientToolCallItem).Name}");
                        chatkitClientToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TaskItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TaskItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TaskItem).Name}");
                        chatkitTask = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TaskGroupItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TaskGroupItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TaskGroupItem).Name}");
                        chatkitTaskGroup = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatkitUserMessage == null && chatkitAssistantMessage == null && chatkitWidget == null && chatkitClientToolCall == null && chatkitTask == null && chatkitTaskGroup == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageItem).Name}");
                    chatkitUserMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AssistantMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AssistantMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AssistantMessageItem).Name}");
                    chatkitAssistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WidgetMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WidgetMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WidgetMessageItem).Name}");
                    chatkitWidget = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ClientToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ClientToolCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ClientToolCallItem).Name}");
                    chatkitClientToolCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TaskItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TaskItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TaskItem).Name}");
                    chatkitTask = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TaskGroupItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TaskGroupItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TaskGroupItem).Name}");
                    chatkitTaskGroup = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::tryAGI.OpenAI.ThreadItem(
                chatkitUserMessage,

                chatkitAssistantMessage,

                chatkitWidget,

                chatkitClientToolCall,

                chatkitTask,

                chatkitTaskGroup
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::tryAGI.OpenAI.ThreadItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatkitUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.UserMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.UserMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.UserMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatkitUserMessage, typeInfo);
            }
            else if (value.IsChatkitAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.AssistantMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.AssistantMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.AssistantMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatkitAssistantMessage, typeInfo);
            }
            else if (value.IsChatkitWidget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.WidgetMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.WidgetMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.WidgetMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatkitWidget, typeInfo);
            }
            else if (value.IsChatkitClientToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.ClientToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.ClientToolCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.ClientToolCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatkitClientToolCall, typeInfo);
            }
            else if (value.IsChatkitTask)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TaskItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TaskItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TaskItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatkitTask, typeInfo);
            }
            else if (value.IsChatkitTaskGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::tryAGI.OpenAI.TaskGroupItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::tryAGI.OpenAI.TaskGroupItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::tryAGI.OpenAI.TaskGroupItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatkitTaskGroup, typeInfo);
            }
        }
    }
}